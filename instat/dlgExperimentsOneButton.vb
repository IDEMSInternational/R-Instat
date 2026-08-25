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
    Private bResetChecksSubdialog As Boolean = True

    Private ReadOnly strLastModel As String = "last_model"
    Private ReadOnly strLastGraph As String = "last_graph"

    Private ptRepLabelDefaultLocation As Point
    Private ptRepReceiverDefaultLocation As Point

    Private clsBkRbdFunction As New RFunction
    Private clsBkFrbdFunction As New RFunction
    Private clsBkDiallelFunction As New RFunction
    Private clsBkLxtFunction As New RFunction
    Private clsBkAugmentedFunction As New RFunction

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

        ttDesign.SetToolTip(rdoLxt, "Line by Tester")

        ucrSelectorForRank.SetParameter(New RParameter("data", 0))
        ucrSelectorForRank.SetParameterIsrfunction()

        ucrReceiverResponse.Selector = ucrSelectorForRank
        ucrReceiverResponse.SetParameter(New RParameter("trait", 1))
        ucrReceiverResponse.SetParameterIsString()
        ucrReceiverResponse.SetDataType("numeric")
        ucrReceiverResponse.strSelectorHeading = "Numerics"

        UcrCheckAlphaExperiments.SetText("Alpha")
        ucrAlpha.SetItems({"0.001", "0.01", "0.02", "0.05", "0.1"})
        ucrAlpha.SetDropDownStyleAsNonEditable()
        ucrAlpha.AddQuotesIfUnrecognised = False
        ucrAlpha.SetParameter(New RParameter("alpha", 4))
        UcrCheckAlphaExperiments.AddToLinkedControls(ucrAlpha, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05")

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

        ucrChkPlot.SetText("Generate Plot")
        ucrChkPlot.AddParameterValuesCondition(True, "plot", "True")
        ucrChkPlot.AddParameterValuesCondition(False, "plot", "False")

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

        ptRepLabelDefaultLocation = lblRep.Location
        ptRepReceiverDefaultLocation = ucrRep.Location
    End Sub

    Private Sub SetDefaults()
        bRCodeSet = False
        bResetChecksSubdialog = True

        clsBkRbdFunction = New RFunction
        clsBkFrbdFunction = New RFunction
        clsBkDiallelFunction = New RFunction
        clsBkLxtFunction = New RFunction
        clsBkAugmentedFunction = New RFunction
        clsBkPlotFunction = New RFunction
        clsCheckGraphFunction = New RFunction
        clsAddPlotObjectFunction = New RFunction
        clsGetPlotObjectDataFunction = New RFunction
        clsDummyFunction = New RFunction

        ucrSelectorForRank.Reset()
        ucrSave.Reset()
        ucrSaveGraph.Reset()
        ucrReceiverResponse.SetMeAsReceiver()
        ucrSave.ucrChkSave.Checked = False
        ucrSaveGraph.ucrChkSave.Checked = False

        clsDummyFunction.AddParameter("top_option", "General", iPosition:=0)
        clsDummyFunction.AddParameter("plot", "True", iPosition:=1)
        clsDummyFunction.AddParameter("design", Chr(34) & "rbd" & Chr(34), iPosition:=2)

        clsCurrentDataFrameFunction = ucrSelectorForRank.ucrAvailableDataFrames.clsCurrDataFrame

        clsBkRbdFunction.SetPackageName("BKBreed")
        clsBkRbdFunction.SetRCommand("bk_rbd")
        clsBkRbdFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)

        clsBkFrbdFunction.SetPackageName("BKBreed")
        clsBkFrbdFunction.SetRCommand("bk_frbd")
        clsBkFrbdFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)

        clsBkDiallelFunction.SetPackageName("BKBreed")
        clsBkDiallelFunction.SetRCommand("bk_diallel")
        clsBkDiallelFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)

        clsBkLxtFunction.SetPackageName("BKBreed")
        clsBkLxtFunction.SetRCommand("bk_lxt")
        clsBkLxtFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)

        clsBkAugmentedFunction.SetPackageName("BKBreed")
        clsBkAugmentedFunction.SetRCommand("bk_augmented")
        clsBkAugmentedFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)

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

        UcrBaseExperimentsOneButton.clsRsyntax.ClearCodes()
        UcrBaseExperimentsOneButton.clsRsyntax.SetBaseRFunction(clsBkRbdFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bRCodeSet = False

        ucrAlpha.AddAdditionalCodeParameterPair(clsBkFrbdFunction, New RParameter("alpha", 5), iAdditionalPairNo:=1)
        ucrAlpha.AddAdditionalCodeParameterPair(clsBkDiallelFunction, New RParameter("alpha", 5), iAdditionalPairNo:=2)
        ucrAlpha.AddAdditionalCodeParameterPair(clsBkLxtFunction, New RParameter("alpha", 5), iAdditionalPairNo:=3)
        ucrAlpha.AddAdditionalCodeParameterPair(clsBkAugmentedFunction, New RParameter("alpha", 6), iAdditionalPairNo:=4)
        ucrAlpha.SetRCode(clsBkRbdFunction, bReset)

        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsBkFrbdFunction, New RParameter("trait", 1), iAdditionalPairNo:=1)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsBkDiallelFunction, New RParameter("trait", 1), iAdditionalPairNo:=2)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsBkLxtFunction, New RParameter("trait", 1), iAdditionalPairNo:=3)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsBkAugmentedFunction, New RParameter("trait", 1), iAdditionalPairNo:=4)
        ucrReceiverResponse.SetRCode(clsBkRbdFunction, bReset)

        UcrReceiverTreat.AddAdditionalCodeParameterPair(clsBkAugmentedFunction, New RParameter("gen", 2), iAdditionalPairNo:=1)
        UcrReceiverTreat.SetRCode(clsBkRbdFunction, bReset)

        ucrReceiverFactorA.AddAdditionalCodeParameterPair(clsBkDiallelFunction, New RParameter("parent1", 2), iAdditionalPairNo:=1)
        ucrReceiverFactorA.AddAdditionalCodeParameterPair(clsBkLxtFunction, New RParameter("line", 2), iAdditionalPairNo:=2)
        ucrReceiverFactorA.SetRCode(clsBkFrbdFunction, bReset)

        ucrReceiverFactorB.AddAdditionalCodeParameterPair(clsBkDiallelFunction, New RParameter("parent2", 3), iAdditionalPairNo:=1)
        ucrReceiverFactorB.AddAdditionalCodeParameterPair(clsBkLxtFunction, New RParameter("tester", 3), iAdditionalPairNo:=2)
        ucrReceiverFactorB.SetRCode(clsBkFrbdFunction, bReset)

        ucrRep.AddAdditionalCodeParameterPair(clsBkFrbdFunction, New RParameter("rep", 4), iAdditionalPairNo:=1)
        ucrRep.AddAdditionalCodeParameterPair(clsBkDiallelFunction, New RParameter("rep", 4), iAdditionalPairNo:=2)
        ucrRep.AddAdditionalCodeParameterPair(clsBkLxtFunction, New RParameter("rep", 4), iAdditionalPairNo:=3)
        ucrRep.AddAdditionalCodeParameterPair(clsBkAugmentedFunction, New RParameter("rep", 4), iAdditionalPairNo:=4)
        ucrRep.SetRCode(clsBkRbdFunction, bReset)

        ucrSave.AddAdditionalRCode(clsBkFrbdFunction, iAdditionalPairNo:=1)
        ucrSave.AddAdditionalRCode(clsBkDiallelFunction, iAdditionalPairNo:=2)
        ucrSave.AddAdditionalRCode(clsBkLxtFunction, iAdditionalPairNo:=3)
        ucrSave.AddAdditionalRCode(clsBkAugmentedFunction, iAdditionalPairNo:=4)
        ucrSave.SetRCode(clsBkRbdFunction, bReset)

        ucrBlock.SetRCode(clsBkAugmentedFunction, bReset)

        If bReset Then
            UcrCheckAlphaExperiments.AddAdditionalCodeParameterPair(clsBkFrbdFunction, New RParameter("alpha", 5), iAdditionalPairNo:=1)
            UcrCheckAlphaExperiments.AddAdditionalCodeParameterPair(clsBkDiallelFunction, New RParameter("alpha", 5), iAdditionalPairNo:=2)
            UcrCheckAlphaExperiments.AddAdditionalCodeParameterPair(clsBkLxtFunction, New RParameter("alpha", 5), iAdditionalPairNo:=3)
            UcrCheckAlphaExperiments.AddAdditionalCodeParameterPair(clsBkAugmentedFunction, New RParameter("alpha", 6), iAdditionalPairNo:=4)
            UcrCheckAlphaExperiments.SetRCode(clsBkRbdFunction, bReset)

            ucrPnlExperimentsOneButtonOptions.SetRCode(clsDummyFunction, bReset)
            ucrChkPlot.SetRCode(clsDummyFunction, bReset)
            ucrPnlDesign.SetRCode(clsDummyFunction, bReset)
        End If

        UpdatePlotCode()
        bRCodeSet = True
    End Sub

    ' At least 2 check varieties must be selected before OK/To Script is enabled.
    ' If none have been selected yet, the "checks" parameter either doesn't exist on the
    ' function or its value is empty, so there are 0 checks. Otherwise, sdgChecksFromFactor writes "checks" as a plain quoted name string (e.g. c("A", "B"))
    Private Function GetCheckedVarietyCount() As Integer
        Dim clsChecksParameter As RParameter = clsBkAugmentedFunction.GetParameter("checks")
        If clsChecksParameter Is Nothing OrElse String.IsNullOrEmpty(clsChecksParameter.strArgumentValue) Then
            Return 0
        End If
        Dim iQuoteCount As Integer = clsChecksParameter.strArgumentValue.Count(Function(c) c = Chr(34))
        Return iQuoteCount \ 2
    End Function

    Private Sub btnChecks_Click(sender As Object, e As EventArgs) Handles btnChecks.Click
        sdgChecksSubdialog.SetRFunction(clsBkAugmentedFunction, UcrReceiverTreat, bResetChecksSubdialog)
        sdgChecksSubdialog.ShowDialog()
        bResetChecksSubdialog = False
        TestOKEnabled()
    End Sub


    ' Returns True only when every receiver required by the currently selected design has a
    ' value. Response and Rep are required for every design; Factor A/B only for the
    ' factor-pair designs (Factorial/Diallel/Lxt); Treat for rbd and Augmented; Block only
    ' for Augmented.
    Private Function CheckReceiversAreComplete() As Boolean
        If ucrReceiverResponse.IsEmpty() OrElse ucrRep.IsEmpty() Then Return False

        If rdoFactorial.Checked OrElse rdoDiallel.Checked OrElse rdoLxt.Checked Then
            Return Not ucrReceiverFactorA.IsEmpty() AndAlso Not ucrReceiverFactorB.IsEmpty()
        ElseIf rdoAugmented.Checked Then
            Return Not UcrReceiverTreat.IsEmpty() AndAlso Not ucrBlock.IsEmpty()
        Else
            Return Not UcrReceiverTreat.IsEmpty()
        End If
    End Function

    Private Sub TestOKEnabled()
        If Not CheckReceiversAreComplete() OrElse Not ucrSave.IsComplete Then
            UcrBaseExperimentsOneButton.OKEnabled(False)
            Return
        End If
        If rdoAugmented.Checked AndAlso GetCheckedVarietyCount() < 2 Then
            UcrBaseExperimentsOneButton.OKEnabled(False)
            Return
        End If
        UcrBaseExperimentsOneButton.OKEnabled(True)
    End Sub

    Private Sub UcrBaseExperimentsOneButton_ClickReset(sender As Object, e As EventArgs) Handles UcrBaseExperimentsOneButton.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub


    ' Fires when the selected design changes. Shows/hides the controls relevant to the new
    ' design (Factor A/B vs Treatment, Block/Checks for Augmented only), repositions the Rep
    ' row when Augmented needs room for the Block row above it, and relabels Factor A/B per
    ' design. If the tree is already bound, swaps the dialog's base R function and refreshes
    ' the plot code to match.
    Private Sub DesignRadio_CheckedChanged(sender As Object, e As EventArgs) Handles rdorbd.CheckedChanged, rdoFactorial.CheckedChanged,
        rdoDiallel.CheckedChanged, rdoLxt.CheckedChanged, rdoAugmented.CheckedChanged

        Dim rdoChanged As RadioButton = DirectCast(sender, RadioButton)
        If Not rdoChanged.Checked Then Return

        Dim bIsFactorLike As Boolean = rdoFactorial.Checked OrElse rdoDiallel.Checked OrElse rdoLxt.Checked
        Dim bIsAugmented As Boolean = rdoAugmented.Checked
        Dim bIsGeneralAlphaDesign As Boolean = rdorbd.Checked OrElse bIsFactorLike OrElse bIsAugmented

        lblFactorA.Visible = bIsFactorLike
        ucrReceiverFactorA.Visible = bIsFactorLike
        lblFactorB.Visible = bIsFactorLike
        ucrReceiverFactorB.Visible = bIsFactorLike
        lblTreat.Visible = Not bIsFactorLike
        UcrReceiverTreat.Visible = Not bIsFactorLike

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

        UcrCheckAlphaExperiments.Visible = bIsGeneralAlphaDesign
        ucrAlpha.Visible = bIsGeneralAlphaDesign AndAlso UcrCheckAlphaExperiments.Checked

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
        End If
        Return clsBkRbdFunction
    End Function

    Private Sub ucrSelectorForRank_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForRank.ControlValueChanged
        bResetChecksSubdialog = True
        clsCurrentDataFrameFunction = ucrSelectorForRank.ucrAvailableDataFrames.clsCurrDataFrame
        clsBkRbdFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        clsBkFrbdFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        clsBkDiallelFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        clsBkLxtFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        clsBkAugmentedFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        UpdatePlotDataFrameName()
    End Sub

    Private Sub ucrChkPlot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPlot.ControlValueChanged
        If bRCodeSet Then
            UpdatePlotCode()
        End If
    End Sub

    Private Sub ucrSave_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSave.ControlValueChanged, ucrSaveGraph.ControlValueChanged
        If bRCodeSet Then
            UpdatePlotCode()
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverResponse.ControlContentsChanged, UcrReceiverTreat.ControlContentsChanged,
        ucrReceiverFactorA.ControlContentsChanged, ucrReceiverFactorB.ControlContentsChanged,
        ucrRep.ControlContentsChanged, ucrBlock.ControlContentsChanged, ucrAlpha.ControlContentsChanged,
        ucrSave.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged

        If bRCodeSet Then
            TestOKEnabled()
            UpdatePlotCode()
        End If
    End Sub

    'Pushes the current data frame's name into the plot-pipeline functions that need to reference it ($add_object / $get_object_data).
    Private Sub UpdatePlotDataFrameName()
        Dim strDataFrame As String = ucrSelectorForRank.ucrAvailableDataFrames.cboAvailableDataFrames.Text
        clsAddPlotObjectFunction.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
        clsGetPlotObjectDataFunction.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
    End Sub

    'Rebuilds the after-code plot pipeline bk_plot -> check_graph -> $add_object -> $get_object_data
    'strips the old pipeline first so toggling "Generate Plot" off removes it cleanly
    'only re-adds it If the checkbox Is checked And both a model name And graph name can be resolved.
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