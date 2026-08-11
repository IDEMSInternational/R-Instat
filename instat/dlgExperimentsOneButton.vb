' R-Instat
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
Public Class dlgExperimentsOneButton

    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bRCodeSet As Boolean = True

    Private ReadOnly strLastModel As String = "last_model"
    Private ReadOnly strLastGraph As String = "last_graph"

    Private ptRepLabelDefaultLocation As Point
    Private ptRepReceiverDefaultLocation As Point

    Private clsBkRbdFunction As New RFunction
    Private clsBkFrbdFunction As New RFunction
    Private clsBkDiallelFunction As New RFunction
    Private clsBkLxtFunction As New RFunction
    Private clsBkAugmentedFunction As New RFunction
    Private clsBkDiversityFunction As New RFunction
    Private clsBkPathFunction As New RFunction
    Private clsBkStabilityFunction As New RFunction
    Private clsBkVariabilityFunction As New RFunction
    Private clsBkCorrelationFunction As New RFunction
    Private clsChecksVectorFunction As New RFunction

    Private clsBkPlotFunction As New RFunction
    Private clsCheckGraphFunction As New RFunction
    Private clsAddPlotObjectFunction As New RFunction
    Private clsGetPlotObjectDataFunction As New RFunction
    Private clsDummyFunction As New RFunction

    Private clsCurrentDataFrameFunction As New RFunction

    Private Sub dlgExperimentsOneButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        UcrBaseExperimentsOneButton.iHelpTopicID = 0
        UcrBaseExperimentsOneButton.clsRsyntax.iCallType = 2
        UcrBaseExperimentsOneButton.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrPnlExperimentsOneButtonOptions.AddRadioButton(rdoGeneral)
        ucrPnlExperimentsOneButtonOptions.AddRadioButton(rdoSpecial)
        ucrPnlExperimentsOneButtonOptions.AddParameterValuesCondition(rdoGeneral, "top_option", "General")
        ucrPnlExperimentsOneButtonOptions.AddParameterValuesCondition(rdoSpecial, "top_option", "Special")

        ucrPnlDesign.SetParameter(New RParameter("design", 1))
        ucrPnlDesign.AddRadioButton(rdorbd, Chr(34) & "rbd" & Chr(34))
        ucrPnlDesign.AddRadioButton(rdoFactorial, Chr(34) & "frbd" & Chr(34))
        ucrPnlDesign.AddRadioButton(rdoDiallel, Chr(34) & "diallel" & Chr(34))
        ucrPnlDesign.AddRadioButton(rdoLxt, Chr(34) & "lxt" & Chr(34))
        ucrPnlDesign.AddRadioButton(rdoAugmented, Chr(34) & "augmented" & Chr(34))
        ucrPnlDesign.AddRadioButton(rdoDiversity, Chr(34) & "diversity" & Chr(34))
        ucrPnlDesign.AddRadioButton(rdoPath, Chr(34) & "path" & Chr(34))
        ucrPnlDesign.AddRadioButton(rdoStability, Chr(34) & "stability" & Chr(34))
        ucrPnlDesign.AddRadioButton(rdoVariability, Chr(34) & "variability" & Chr(34))
        ucrPnlDesign.AddRadioButton(rdoCorrelations, Chr(34) & "correlation" & Chr(34))

        ttDesign.SetToolTip(rdoLxt, "Line by Tester")
        ttVariability.SetToolTip(ucrSelectionDifferential, "The value 2.063 is the differential for 5% intensity")

        ucrSelectorForRank.SetParameter(New RParameter("data", 0))
        ucrSelectorForRank.SetParameterIsrfunction()

        ucrReceiverResponse.Selector = ucrSelectorForRank
        ucrReceiverResponse.SetParameter(New RParameter("trait", 1))
        ucrReceiverResponse.SetParameterIsString()
        ucrReceiverResponse.SetDataType("numeric")
        ucrReceiverResponse.strSelectorHeading = "Numerics"

        ucrReceiverResponseMulti.Selector = ucrSelectorForRank
        ucrReceiverResponseMulti.SetParameter(New RParameter("traits", 1))
        ucrReceiverResponseMulti.SetDataType("numeric")
        ucrReceiverResponseMulti.strSelectorHeading = "Numerics"

        UcrReceiverTreat.Selector = ucrSelectorForRank
        UcrReceiverTreat.SetParameter(New RParameter("gen", 2))
        UcrReceiverTreat.SetParameterIsString()
        UcrReceiverTreat.SetDataType("factor")
        UcrReceiverTreat.strSelectorHeading = "Factors"

        ucrReceiverFactorA.Selector = ucrSelectorForRank
        ucrReceiverFactorA.SetParameter(New RParameter("factorA", 2))
        ucrReceiverFactorA.SetParameterIsString()
        ucrReceiverFactorA.SetDataType("factor")
        ucrReceiverFactorA.strSelectorHeading = "Factors"

        ucrReceiverFactorB.Selector = ucrSelectorForRank
        ucrReceiverFactorB.SetParameter(New RParameter("factorB", 3))
        ucrReceiverFactorB.SetParameterIsString()
        ucrReceiverFactorB.SetDataType("factor")
        ucrReceiverFactorB.strSelectorHeading = "Factors"

        ucrRep.Selector = ucrSelectorForRank
        ucrRep.SetParameter(New RParameter("rep", 3))
        ucrRep.SetParameterIsString()
        ucrRep.SetDataType("factor")
        ucrRep.strSelectorHeading = "Factors"

        ucrBlock.Selector = ucrSelectorForRank
        ucrBlock.SetParameter(New RParameter("block", 3))
        ucrBlock.SetParameterIsString()
        ucrBlock.SetDataType("factor")
        ucrBlock.strSelectorHeading = "Factors"

        ucrReceiverExplanatory.Selector = ucrSelectorForRank
        ucrReceiverExplanatory.SetParameter(New RParameter("traits", 1))
        ucrReceiverExplanatory.SetDataType("numeric")
        ucrReceiverExplanatory.strSelectorHeading = "Numerics"

        ucrReceiverLocations.Selector = ucrSelectorForRank
        ucrReceiverLocations.SetParameter(New RParameter("env", 3))
        ucrReceiverLocations.SetParameterIsString()
        ucrReceiverLocations.SetDataType("factor")
        ucrReceiverLocations.strSelectorHeading = "Factors"

        ucrChkPlot.SetText("Generate Plot")
        ucrChkPlot.AddParameterValuesCondition(True, "plot", "True")
        ucrChkPlot.AddParameterValuesCondition(False, "plot", "False")

        ucrAlpha.SetParameter(New RParameter("alpha", 4))
        Dim dctAlpha As New Dictionary(Of String, String)
        dctAlpha.Add("0.001", "0.001")
        dctAlpha.Add("0.01", "0.01")
        dctAlpha.Add("0.02", "0.02")
        dctAlpha.Add("0.05", "0.05")
        dctAlpha.Add("0.1", "0.1")
        ucrAlpha.SetItems(dctAlpha)
        ucrAlpha.SetDropDownStyleAsNonEditable()

        btnChecks.Enabled = False

        ucrPnlClusterMethod.SetParameter(New RParameter("method", 4))
        ucrPnlClusterMethod.AddRadioButton(rdoTocher, Chr(34) & "tocher" & Chr(34))
        ucrPnlClusterMethod.AddRadioButton(rdoHierarchical, Chr(34) & "hierarchical" & Chr(34))
        ucrPnlClusterMethod.AddToLinkedControls(ucrNumClusters, {rdoHierarchical}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrNumClusters.SetParameter(New RParameter("clusters", 5))
        ucrNumClusters.SetMinMax(1, 20)
        ucrNumClusters.DecimalPlaces = 0
        ucrNumClusters.Increment = 1
        ucrNumClusters.SetRDefault(3)

        ucrPnlCorrelationType.SetParameter(New RParameter("type", 5))
        ucrPnlCorrelationType.AddRadioButton(rdoGenotypic, Chr(34) & "genotypic" & Chr(34))
        ucrPnlCorrelationType.AddRadioButton(rdoPhenotypic, Chr(34) & "phenotypic" & Chr(34))

        ucrSelectionDifferential.SetParameter(New RParameter("k", 4))
        ucrSelectionDifferential.SetMinMax(0, 10)
        ucrSelectionDifferential.DecimalPlaces = 3
        ucrSelectionDifferential.Increment = 0.001
        ucrSelectionDifferential.SetRDefault(2.063)

        ucrSave.SetSaveTypeAsModel()
        ucrSave.SetPrefix("one_button_model")
        ucrSave.SetDataFrameSelector(ucrSelectorForRank.ucrAvailableDataFrames)
        ucrSave.SetCheckBoxText("Store Model")
        ucrSave.SetIsComboBox()
        ucrSave.SetAssignToIfUncheckedValue(strLastModel)

        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetPrefix("one_button_graph")
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorForRank.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Store Graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue(strLastGraph)

        lblNumClusters.Visible = rdoHierarchical.Checked

        ptRepLabelDefaultLocation = lblRep.Location
        ptRepReceiverDefaultLocation = ucrRep.Location
    End Sub

    Private Sub SetDefaults()
        bRCodeSet = False

        clsBkRbdFunction = New RFunction
        clsBkFrbdFunction = New RFunction
        clsBkDiallelFunction = New RFunction
        clsBkLxtFunction = New RFunction
        clsBkAugmentedFunction = New RFunction
        clsBkDiversityFunction = New RFunction
        clsBkPathFunction = New RFunction
        clsBkStabilityFunction = New RFunction
        clsBkVariabilityFunction = New RFunction
        clsBkCorrelationFunction = New RFunction
        clsChecksVectorFunction = New RFunction
        clsBkPlotFunction = New RFunction
        clsCheckGraphFunction = New RFunction
        clsAddPlotObjectFunction = New RFunction
        clsGetPlotObjectDataFunction = New RFunction
        clsDummyFunction = New RFunction

        ucrSelectorForRank.Reset()
        ucrSave.Reset()
        ucrSaveGraph.Reset()
        ucrReceiverResponse.SetMeAsReceiver()

        clsDummyFunction.AddParameter("top_option", "General", iPosition:=0)
        clsDummyFunction.AddParameter("plot", "True", iPosition:=1)
        clsDummyFunction.AddParameter("design", Chr(34) & "rbd" & Chr(34), iPosition:=2)

        clsCurrentDataFrameFunction = ucrSelectorForRank.ucrAvailableDataFrames.clsCurrDataFrame

        clsBkRbdFunction.SetPackageName("BKBreed")
        clsBkRbdFunction.SetRCommand("bk_rbd")
        clsBkRbdFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        clsBkRbdFunction.AddParameter("alpha", "0.05", iPosition:=4)

        clsBkFrbdFunction.SetPackageName("BKBreed")
        clsBkFrbdFunction.SetRCommand("bk_frbd")
        clsBkFrbdFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        clsBkFrbdFunction.AddParameter("alpha", "0.05", iPosition:=5)

        clsBkDiallelFunction.SetPackageName("BKBreed")
        clsBkDiallelFunction.SetRCommand("bk_diallel")
        clsBkDiallelFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        clsBkDiallelFunction.AddParameter("alpha", "0.05", iPosition:=5)

        clsBkLxtFunction.SetPackageName("BKBreed")
        clsBkLxtFunction.SetRCommand("bk_lxt")
        clsBkLxtFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        clsBkLxtFunction.AddParameter("alpha", "0.05", iPosition:=5)

        clsBkAugmentedFunction.SetPackageName("BKBreed")
        clsBkAugmentedFunction.SetRCommand("bk_augmented")
        clsBkAugmentedFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        clsBkAugmentedFunction.AddParameter("alpha", "0.05", iPosition:=6)

        clsBkDiversityFunction.SetPackageName("BKBreed")
        clsBkDiversityFunction.SetRCommand("bk_diversity")
        clsBkDiversityFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        clsBkDiversityFunction.AddParameter("method", Chr(34) & "tocher" & Chr(34), iPosition:=4)

        clsBkPathFunction.SetPackageName("BKBreed")
        clsBkPathFunction.SetRCommand("bk_path")
        clsBkPathFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        clsBkPathFunction.AddParameter("type", Chr(34) & "genotypic" & Chr(34), iPosition:=5)

        clsBkStabilityFunction.SetPackageName("BKBreed")
        clsBkStabilityFunction.SetRCommand("bk_stability")
        clsBkStabilityFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)

        clsBkVariabilityFunction.SetPackageName("BKBreed")
        clsBkVariabilityFunction.SetRCommand("bk_variability")
        clsBkVariabilityFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        clsBkVariabilityFunction.AddParameter("k", "2.063", iPosition:=4)

        clsBkCorrelationFunction.SetPackageName("BKBreed")
        clsBkCorrelationFunction.SetRCommand("bk_correlation")
        clsBkCorrelationFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)

        clsChecksVectorFunction.SetRCommand("c")

        clsBkPlotFunction.SetPackageName("BKBreed")
        clsBkPlotFunction.SetRCommand("bk_plot")
        clsBkPlotFunction.SetAssignTo(strLastGraph)

        clsCheckGraphFunction.SetPackageName("instatExtras")
        clsCheckGraphFunction.SetRCommand("check_graph")
        clsCheckGraphFunction.AddParameter("graph_object", strLastGraph, iPosition:=0)

        clsAddPlotObjectFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_object")
        clsAddPlotObjectFunction.AddParameter("object_name", Chr(34) & strLastGraph & Chr(34), iPosition:=1)
        clsAddPlotObjectFunction.AddParameter("object_type_label", Chr(34) & "graph" & Chr(34), iPosition:=2)
        clsAddPlotObjectFunction.AddParameter("object_format", Chr(34) & "image" & Chr(34), iPosition:=3)
        clsAddPlotObjectFunction.AddParameter("object", clsRFunctionParameter:=clsCheckGraphFunction, iPosition:=4)

        clsGetPlotObjectDataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
        clsGetPlotObjectDataFunction.AddParameter("object_name", Chr(34) & strLastGraph & Chr(34), iPosition:=1)
        clsGetPlotObjectDataFunction.AddParameter("as_file", "TRUE", iPosition:=2)

        UpdatePlotDataFrameName()

        rdoGeneral.Checked = True
        rdorbd.Checked = True
        rdoTocher.Checked = True
        rdoGenotypic.Checked = True

        UcrBaseExperimentsOneButton.clsRsyntax.ClearCodes()
        UcrBaseExperimentsOneButton.clsRsyntax.SetBaseRFunction(clsBkRbdFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bRCodeSet = False

        ucrAlpha.SetRCode(clsBkRbdFunction, bReset)
        ucrAlpha.AddAdditionalCodeParameterPair(clsBkFrbdFunction, New RParameter("alpha", 5), iAdditionalPairNo:=1)
        ucrAlpha.AddAdditionalCodeParameterPair(clsBkDiallelFunction, New RParameter("alpha", 5), iAdditionalPairNo:=2)
        ucrAlpha.AddAdditionalCodeParameterPair(clsBkLxtFunction, New RParameter("alpha", 5), iAdditionalPairNo:=3)
        ucrAlpha.AddAdditionalCodeParameterPair(clsBkAugmentedFunction, New RParameter("alpha", 6), iAdditionalPairNo:=4)

        ucrReceiverResponse.SetRCode(clsBkRbdFunction, bReset)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsBkFrbdFunction, New RParameter("trait", 1), iAdditionalPairNo:=1)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsBkDiallelFunction, New RParameter("trait", 1), iAdditionalPairNo:=2)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsBkLxtFunction, New RParameter("trait", 1), iAdditionalPairNo:=3)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsBkAugmentedFunction, New RParameter("trait", 1), iAdditionalPairNo:=4)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsBkDiversityFunction, New RParameter("traits", 1), iAdditionalPairNo:=5)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsBkPathFunction, New RParameter("dependent", 2), iAdditionalPairNo:=6)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsBkStabilityFunction, New RParameter("trait", 1), iAdditionalPairNo:=7)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsBkVariabilityFunction, New RParameter("traits", 1), iAdditionalPairNo:=8)

        ucrReceiverResponseMulti.SetRCode(clsBkCorrelationFunction, bReset)

        UcrReceiverTreat.SetRCode(clsBkRbdFunction, bReset)
        UcrReceiverTreat.AddAdditionalCodeParameterPair(clsBkAugmentedFunction, New RParameter("gen", 2), iAdditionalPairNo:=1)
        UcrReceiverTreat.AddAdditionalCodeParameterPair(clsBkDiversityFunction, New RParameter("gen", 2), iAdditionalPairNo:=2)
        UcrReceiverTreat.AddAdditionalCodeParameterPair(clsBkPathFunction, New RParameter("gen", 3), iAdditionalPairNo:=3)
        UcrReceiverTreat.AddAdditionalCodeParameterPair(clsBkStabilityFunction, New RParameter("gen", 2), iAdditionalPairNo:=4)
        UcrReceiverTreat.AddAdditionalCodeParameterPair(clsBkVariabilityFunction, New RParameter("gen", 2), iAdditionalPairNo:=5)
        UcrReceiverTreat.AddAdditionalCodeParameterPair(clsBkCorrelationFunction, New RParameter("gen", 2), iAdditionalPairNo:=6)

        ucrReceiverFactorA.SetRCode(clsBkFrbdFunction, bReset)
        ucrReceiverFactorA.AddAdditionalCodeParameterPair(clsBkDiallelFunction, New RParameter("parent1", 2), iAdditionalPairNo:=1)
        ucrReceiverFactorA.AddAdditionalCodeParameterPair(clsBkLxtFunction, New RParameter("line", 2), iAdditionalPairNo:=2)

        ucrReceiverFactorB.SetRCode(clsBkFrbdFunction, bReset)
        ucrReceiverFactorB.AddAdditionalCodeParameterPair(clsBkDiallelFunction, New RParameter("parent2", 3), iAdditionalPairNo:=1)
        ucrReceiverFactorB.AddAdditionalCodeParameterPair(clsBkLxtFunction, New RParameter("tester", 3), iAdditionalPairNo:=2)

        ucrRep.SetRCode(clsBkRbdFunction, bReset)
        ucrRep.AddAdditionalCodeParameterPair(clsBkFrbdFunction, New RParameter("rep", 4), iAdditionalPairNo:=1)
        ucrRep.AddAdditionalCodeParameterPair(clsBkDiallelFunction, New RParameter("rep", 4), iAdditionalPairNo:=2)
        ucrRep.AddAdditionalCodeParameterPair(clsBkLxtFunction, New RParameter("rep", 4), iAdditionalPairNo:=3)
        ucrRep.AddAdditionalCodeParameterPair(clsBkAugmentedFunction, New RParameter("rep", 4), iAdditionalPairNo:=4)
        ucrRep.AddAdditionalCodeParameterPair(clsBkDiversityFunction, New RParameter("rep", 3), iAdditionalPairNo:=5)
        ucrRep.AddAdditionalCodeParameterPair(clsBkPathFunction, New RParameter("rep", 4), iAdditionalPairNo:=6)
        ucrRep.AddAdditionalCodeParameterPair(clsBkStabilityFunction, New RParameter("rep", 4), iAdditionalPairNo:=7)
        ucrRep.AddAdditionalCodeParameterPair(clsBkVariabilityFunction, New RParameter("rep", 3), iAdditionalPairNo:=8)
        ucrRep.AddAdditionalCodeParameterPair(clsBkCorrelationFunction, New RParameter("rep", 3), iAdditionalPairNo:=9)


        ucrSave.SetRCode(clsBkRbdFunction, bReset)
        ucrSave.AddAdditionalRCode(clsBkFrbdFunction, iAdditionalPairNo:=1)
        ucrSave.AddAdditionalRCode(clsBkDiallelFunction, iAdditionalPairNo:=2)
        ucrSave.AddAdditionalRCode(clsBkLxtFunction, iAdditionalPairNo:=3)
        ucrSave.AddAdditionalRCode(clsBkAugmentedFunction, iAdditionalPairNo:=4)
        ucrSave.AddAdditionalRCode(clsBkDiversityFunction, iAdditionalPairNo:=5)
        ucrSave.AddAdditionalRCode(clsBkPathFunction, iAdditionalPairNo:=6)
        ucrSave.AddAdditionalRCode(clsBkStabilityFunction, iAdditionalPairNo:=7)
        ucrSave.AddAdditionalRCode(clsBkVariabilityFunction, iAdditionalPairNo:=8)
        ucrSave.AddAdditionalRCode(clsBkCorrelationFunction, iAdditionalPairNo:=9)

        ucrBlock.SetRCode(clsBkAugmentedFunction, bReset)

        ucrReceiverExplanatory.SetRCode(clsBkPathFunction, bReset)
        ucrReceiverLocations.SetRCode(clsBkStabilityFunction, bReset)

        ucrPnlClusterMethod.SetRCode(clsBkDiversityFunction, bReset)
        ucrNumClusters.SetRCode(clsBkDiversityFunction, bReset)

        ucrPnlCorrelationType.SetRCode(clsBkPathFunction, bReset)

        ucrSelectionDifferential.SetRCode(clsBkVariabilityFunction, bReset)

        If bReset Then
            ucrPnlExperimentsOneButtonOptions.SetRCode(clsDummyFunction, bReset)
            ucrChkPlot.SetRCode(clsDummyFunction, bReset)
            ucrPnlDesign.SetRCode(clsDummyFunction, bReset)
        End If

        UpdatePlotCode()

        bRCodeSet = True
    End Sub

    Private Sub TestOKEnabled()

        If Not ucrSave.IsComplete Then
            UcrBaseExperimentsOneButton.OKEnabled(False)
            Return
        End If

        Dim bIsValid As Boolean = True

        If rdoCorrelations.Checked Then
            bIsValid = bIsValid AndAlso Not ucrReceiverResponseMulti.IsEmpty
        Else
            bIsValid = bIsValid AndAlso Not ucrReceiverResponse.IsEmpty
        End If

        If rdoFactorial.Checked OrElse rdoDiallel.Checked OrElse rdoLxt.Checked Then
            bIsValid = bIsValid AndAlso Not ucrReceiverFactorA.IsEmpty AndAlso Not ucrReceiverFactorB.IsEmpty
        Else
            bIsValid = bIsValid AndAlso Not UcrReceiverTreat.IsEmpty
        End If

        If rdoAugmented.Checked Then
            bIsValid = bIsValid AndAlso Not ucrBlock.IsEmpty
        ElseIf rdoPath.Checked Then
            bIsValid = bIsValid AndAlso Not ucrReceiverExplanatory.IsEmpty AndAlso Not ucrRep.IsEmpty
        ElseIf rdoStability.Checked Then
            bIsValid = bIsValid AndAlso Not ucrReceiverLocations.IsEmpty AndAlso Not ucrRep.IsEmpty
        Else
            bIsValid = bIsValid AndAlso Not ucrRep.IsEmpty
        End If

        UcrBaseExperimentsOneButton.OKEnabled(bIsValid)
    End Sub

    Private Sub UcrBaseExperimentsOneButton_ClickReset(sender As Object, e As EventArgs) Handles UcrBaseExperimentsOneButton.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub DesignRadio_CheckedChanged(sender As Object, e As EventArgs) Handles rdorbd.CheckedChanged, rdoFactorial.CheckedChanged,
        rdoDiallel.CheckedChanged, rdoLxt.CheckedChanged, rdoAugmented.CheckedChanged, rdoDiversity.CheckedChanged,
        rdoPath.CheckedChanged, rdoStability.CheckedChanged, rdoVariability.CheckedChanged, rdoCorrelations.CheckedChanged

        Dim rdoChanged As RadioButton = DirectCast(sender, RadioButton)
        If Not rdoChanged.Checked Then Return

        Dim bIsFactorLike As Boolean = rdoFactorial.Checked OrElse rdoDiallel.Checked OrElse rdoLxt.Checked
        Dim bIsAugmented As Boolean = rdoAugmented.Checked
        Dim bIsDiversity As Boolean = rdoDiversity.Checked
        Dim bIsPath As Boolean = rdoPath.Checked
        Dim bIsStability As Boolean = rdoStability.Checked
        Dim bIsVariability As Boolean = rdoVariability.Checked
        Dim bIsCorrelations As Boolean = rdoCorrelations.Checked
        Dim bIsGeneralAlphaDesign As Boolean = rdorbd.Checked OrElse bIsFactorLike OrElse bIsAugmented
        Dim bIsTreatLike As Boolean = rdorbd.Checked OrElse bIsAugmented OrElse bIsDiversity OrElse
                                       bIsPath OrElse bIsStability OrElse bIsVariability OrElse bIsCorrelations

        lblResponse.Text = If(bIsCorrelations, "Response Variables:", "Response:")
        ucrReceiverResponse.Visible = Not bIsCorrelations
        ucrReceiverResponseMulti.Visible = bIsCorrelations

        lblTreat.Visible = bIsTreatLike
        UcrReceiverTreat.Visible = bIsTreatLike

        lblFactorA.Visible = bIsFactorLike
        ucrReceiverFactorA.Visible = bIsFactorLike
        lblFactorB.Visible = bIsFactorLike
        ucrReceiverFactorB.Visible = bIsFactorLike

        lblBlock.Visible = bIsAugmented
        ucrBlock.Visible = bIsAugmented
        btnChecks.Visible = bIsAugmented

        If bIsAugmented Then
            Dim iRepLabelY As Integer = ucrBlock.Bottom + 6
            Dim iLabelToReceiverOffset As Integer = ptRepReceiverDefaultLocation.Y - ptRepLabelDefaultLocation.Y

            lblRep.Location = New Point(lblRep.Location.X, iRepLabelY)
            ucrRep.Location = New Point(ucrRep.Location.X, iRepLabelY + iLabelToReceiverOffset)
        Else
            lblRep.Location = ptRepLabelDefaultLocation
            ucrRep.Location = ptRepReceiverDefaultLocation
        End If

        lblApha.Visible = bIsGeneralAlphaDesign
        ucrAlpha.Visible = bIsGeneralAlphaDesign

        grpClusterMethod.Visible = bIsDiversity

        lblExplanatory.Visible = bIsPath
        ucrReceiverExplanatory.Visible = bIsPath
        grpCorrelationType.Visible = bIsPath

        lblLocations.Visible = bIsStability
        ucrReceiverLocations.Visible = bIsStability

        lblSelectionDifferential.Visible = bIsVariability
        ucrSelectionDifferential.Visible = bIsVariability

        If rdoFactorial.Checked Then
            lblFactorA.Text = "Factor A:"
            lblFactorB.Text = "Factor B:"
        ElseIf rdoDiallel.Checked Then
            lblFactorA.Text = "Parent 1:"
            lblFactorB.Text = "Parent 2:"
        ElseIf rdoLxt.Checked Then
            lblFactorA.Text = "Line:"
            lblFactorB.Text = "Tester:"
        End If

        If bRCodeSet Then
            UcrBaseExperimentsOneButton.clsRsyntax.SetBaseRFunction(GetActiveDesignFunction())
            UpdatePlotCode()
        End If
        TestOKEnabled()
    End Sub

    Private Sub TopOption_CheckedChanged(sender As Object, e As EventArgs) Handles rdoGeneral.CheckedChanged, rdoSpecial.CheckedChanged
        Dim rdoChanged As RadioButton = DirectCast(sender, RadioButton)
        If Not rdoChanged.Checked Then Return

        Dim bIsGeneralOption As Boolean = rdoGeneral.Checked

        rdorbd.Visible = bIsGeneralOption
        rdoFactorial.Visible = bIsGeneralOption
        rdoDiallel.Visible = bIsGeneralOption
        rdoLxt.Visible = bIsGeneralOption
        rdoAugmented.Visible = bIsGeneralOption

        rdoDiversity.Visible = Not bIsGeneralOption
        rdoPath.Visible = Not bIsGeneralOption
        rdoStability.Visible = Not bIsGeneralOption
        rdoVariability.Visible = Not bIsGeneralOption
        rdoCorrelations.Visible = Not bIsGeneralOption

        If rdoGeneral.Checked AndAlso Not (rdorbd.Checked OrElse rdoFactorial.Checked OrElse rdoDiallel.Checked OrElse
                                            rdoLxt.Checked OrElse rdoAugmented.Checked) Then
            rdorbd.Checked = True
        ElseIf rdoSpecial.Checked AndAlso Not (rdoDiversity.Checked OrElse rdoPath.Checked OrElse rdoStability.Checked OrElse
                                                rdoVariability.Checked OrElse rdoCorrelations.Checked) Then
            rdoDiversity.Checked = True
        End If
    End Sub

    Private Sub ClusterMethod_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTocher.CheckedChanged, rdoHierarchical.CheckedChanged
        lblNumClusters.Visible = rdoHierarchical.Checked
    End Sub

    Private Sub ucrSelectorForRank_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForRank.ControlValueChanged
        clsCurrentDataFrameFunction = ucrSelectorForRank.ucrAvailableDataFrames.clsCurrDataFrame
        clsBkRbdFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        clsBkFrbdFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        clsBkDiallelFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        clsBkLxtFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        clsBkAugmentedFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        clsBkDiversityFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        clsBkPathFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        clsBkStabilityFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        clsBkVariabilityFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        clsBkCorrelationFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        UpdatePlotDataFrameName()
    End Sub

    Private Sub ucrChkPlot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPlot.ControlValueChanged
        If bRCodeSet Then
            UpdatePlotCode()
        End If
    End Sub

    Private Sub ucrPnlClusterMethod_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlClusterMethod.ControlValueChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrSave_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSave.ControlValueChanged, ucrSaveGraph.ControlValueChanged
        If bRCodeSet Then
            UpdatePlotCode()
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverResponse.ControlContentsChanged,
        ucrReceiverResponseMulti.ControlContentsChanged, UcrReceiverTreat.ControlContentsChanged,
        ucrReceiverFactorA.ControlContentsChanged, ucrReceiverFactorB.ControlContentsChanged,
        ucrRep.ControlContentsChanged, ucrBlock.ControlContentsChanged,
        ucrReceiverExplanatory.ControlContentsChanged, ucrReceiverLocations.ControlContentsChanged,
        ucrSave.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged
        If bRCodeSet Then
            TestOKEnabled()
            UpdatePlotCode()
        End If
    End Sub

    Private Sub UpdatePlotDataFrameName()
        Dim strDataFrame As String = ucrSelectorForRank.ucrAvailableDataFrames.cboAvailableDataFrames.Text
        clsAddPlotObjectFunction.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
        clsGetPlotObjectDataFunction.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
    End Sub

    Private Function GetActiveDesignFunction() As RFunction
        If rdorbd.Checked Then
            Return clsBkRbdFunction
        ElseIf rdoFactorial.Checked Then
            Return clsBkFrbdFunction
        ElseIf rdoDiallel.Checked Then
            Return clsBkDiallelFunction
        ElseIf rdoLxt.Checked Then
            Return clsBkLxtFunction
        ElseIf rdoAugmented.Checked Then
            Return clsBkAugmentedFunction
        ElseIf rdoDiversity.Checked Then
            Return clsBkDiversityFunction
        ElseIf rdoPath.Checked Then
            Return clsBkPathFunction
        ElseIf rdoStability.Checked Then
            Return clsBkStabilityFunction
        ElseIf rdoVariability.Checked Then
            Return clsBkVariabilityFunction
        ElseIf rdoCorrelations.Checked Then
            Return clsBkCorrelationFunction
        End If
        Return clsBkRbdFunction
    End Function

    Private Sub UpdatePlotCode()
        UcrBaseExperimentsOneButton.clsRsyntax.RemoveFromAfterCodes(clsGetPlotObjectDataFunction)
        UcrBaseExperimentsOneButton.clsRsyntax.RemoveFromAfterCodes(clsAddPlotObjectFunction)
        UcrBaseExperimentsOneButton.clsRsyntax.RemoveFromAfterCodes(clsBkPlotFunction)

        If Not ucrChkPlot.Checked Then Return

        Dim strModelName As String = If(ucrSave.ucrChkSave.Checked, ucrSave.GetText(), strLastModel)
        Dim strGraphName As String = If(ucrSaveGraph.ucrChkSave.Checked, ucrSaveGraph.GetText(), strLastGraph)
        If String.IsNullOrEmpty(strModelName) OrElse String.IsNullOrEmpty(strGraphName) Then Return

        clsBkPlotFunction.ClearParameters()
        clsBkPlotFunction.AddParameter("x", strModelName, iPosition:=0, bIncludeArgumentName:=False)
        clsBkPlotFunction.SetAssignTo(strGraphName)

        clsCheckGraphFunction.AddParameter("graph_object", strGraphName, iPosition:=0)
        clsAddPlotObjectFunction.AddParameter("object_name", Chr(34) & strGraphName & Chr(34), iPosition:=1)
        clsGetPlotObjectDataFunction.AddParameter("object_name", Chr(34) & strGraphName & Chr(34), iPosition:=1)

        UpdatePlotDataFrameName()

        UcrBaseExperimentsOneButton.clsRsyntax.AddToAfterCodes(clsBkPlotFunction)
        UcrBaseExperimentsOneButton.clsRsyntax.AddToAfterCodes(clsAddPlotObjectFunction)
        UcrBaseExperimentsOneButton.clsRsyntax.AddToAfterCodes(clsGetPlotObjectDataFunction)
    End Sub

End Class