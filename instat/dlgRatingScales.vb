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
Imports RDotNet
Public Class dlgRatingScales
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsSjpLikertFunction, clsSjpStackFrqFunction, clsSjtStackFrqFunction, clsLevelofFactorFunction, clsFactorColumnFunction, clsAsLabelsFunction As New RFunction
    Private Sub dlgRatingScales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 519
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        lblOrderedFactor.Text = "Variables:"

        ucrPnlTableOptions.SetParameter(New RParameter("sort.frq", iNewPosition:=2))
        ucrPnlTableOptions.AddRadioButton(rdoNoneTable, "NULL")
        ucrPnlTableOptions.AddRadioButton(rdoLowAscendingTable, Chr(34) & "last.asc" & Chr(34))
        ucrPnlTableOptions.AddRadioButton(rdoLowDescendingTable, Chr(34) & "last.desc" & Chr(34))
        ucrPnlTableOptions.AddRadioButton(rdoHighAscendingTable, Chr(34) & "first.asc" & Chr(34))
        ucrPnlTableOptions.AddRadioButton(rdoHighDescendingTable, Chr(34) & "first.desc" & Chr(34))
        ucrPnlTableOptions.SetRDefault("NULL")

        ucrPnlLikertOptions.SetParameter(New RParameter("sort.frq", iNewPosition:=2))
        ucrPnlLikertOptions.AddRadioButton(rdoNoneLikert, "NULL")
        ucrPnlLikertOptions.AddRadioButton(rdoLowAscendingLikert, Chr(34) & "neg.asc" & Chr(34))
        ucrPnlLikertOptions.AddRadioButton(rdoLowDescendingLikert, Chr(34) & "neg.desc" & Chr(34))
        ucrPnlLikertOptions.AddRadioButton(rdoHighAscendingLikert, Chr(34) & "pos.asc" & Chr(34))
        ucrPnlLikertOptions.AddRadioButton(rdoHighDescendingLikert, Chr(34) & "pos.desc" & Chr(34))
        ucrPnlLikertOptions.SetRDefault("NULL")

        ucrPnlLikertOptions.SetLinkedDisplayControl(grpSort)

        ucrPnlTableOptions.SetLinkedDisplayControl(grpSortTable)

        ucrPnlGraphType.AddToLinkedControls(ucrPnlLikertOptions, {rdoLikert}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGraphType.AddToLinkedControls(ucrPnlTableOptions, {rdoTable, rdoStacked}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

        ucrPnlGraphType.AddRadioButton(rdoLikert)
        ucrPnlGraphType.AddRadioButton(rdoStacked)
        ucrPnlGraphType.AddRadioButton(rdoTable)

        ucrPnlGraphType.AddFunctionNamesCondition(rdoTable, "tab_stackfrq")
        ucrPnlGraphType.AddFunctionNamesCondition(rdoStacked, "plot_stackfrq")
        ucrPnlGraphType.AddFunctionNamesCondition(rdoLikert, "plot_likert")

        ucrPnlGraphType.AddToLinkedControls(ucrChkFlip, {rdoLikert, rdoStacked}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGraphType.AddToLinkedControls(ucrNudNeutralLevel, {rdoLikert}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=1)
        ucrPnlGraphType.AddToLinkedControls(ucrChkNumberOfCategories, {rdoLikert}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGraphType.AddToLinkedControls(ucrSaveGraph, {rdoStacked, rdoLikert}, bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverOrderedFactors.SetParameter(New RParameter("items", 0))
        ucrReceiverOrderedFactors.SetParameterIsRFunction()
        ucrReceiverOrderedFactors.bForceAsDataFrame = True
        ucrReceiverOrderedFactors.strSelectorHeading = "Variables"
        ucrReceiverOrderedFactors.Selector = ucrSelectorRatingScale

        ucrReceiverWeights.SetParameter(New RParameter("weight.by", 1))
        ucrReceiverWeights.SetParameterIsRFunction()
        ucrReceiverWeights.SetDataType("numeric")
        ucrReceiverWeights.strSelectorHeading = "Numerics"
        ucrReceiverWeights.Selector = ucrSelectorRatingScale
        ucrReceiverWeights.SetRDefault("NULL")

        ucrNudNeutralLevel.SetParameter(New RParameter("cat.neutral", 3))

        ucrChkNumberOfCategories.SetText("Neutral Level:")
        ucrChkNumberOfCategories.SetParameter(ucrNudNeutralLevel.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkNumberOfCategories.AddToLinkedControls(ucrNudNeutralLevel, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrChkNumberOfCategories.AddParameterPresentCondition(True, "cat.neutral")
        ucrChkNumberOfCategories.AddParameterPresentCondition(False, "cat.neutral", False)
        ucrChkNumberOfCategories.SetDefaultState(False)

        ucrChkFlip.SetParameter(New RParameter("coord.flip", 4))
        ucrChkFlip.SetText("Flip Coordinates")
        ucrChkFlip.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkFlip.AddParameterPresentCondition(True, "coord.flip", True)
        ucrChkFlip.AddParameterPresentCondition(False, "coord.flip", False)
        ucrChkFlip.SetRDefault("TRUE")
        ucrChkFlip.SetDefaultState(True)

        ucrChkWeights.SetText("Weights")
        ucrChkWeights.SetParameter(ucrReceiverWeights.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkWeights.AddToLinkedControls(ucrReceiverWeights, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrSaveGraph.SetPrefix("rating_scales")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorRatingScale.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsSjtStackFrqFunction = New RFunction
        clsSjpLikertFunction = New RFunction
        clsSjpStackFrqFunction = New RFunction
        clsAsLabelsFunction = New RFunction
        clsLevelofFactorFunction = New RFunction
        clsFactorColumnFunction = New RFunction

        rdoNoneLikert.Checked = True

        ucrChkFlip.Checked = True
        ucrChkNumberOfCategories.Checked = False

        ucrSaveGraph.Reset()
        ucrSelectorRatingScale.Reset()
        ucrReceiverOrderedFactors.SetMeAsReceiver()
        ucrReceiverOrderedFactors.bForceAsDataFrame = True

        clsAsLabelsFunction.SetPackageName("sjlabelled")
        clsAsLabelsFunction.SetRCommand("as_label")

        clsLevelofFactorFunction.SetRCommand("nlevels")

        clsFactorColumnFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")

        clsSjpLikertFunction.SetPackageName("sjPlot")
        clsSjpLikertFunction.SetRCommand("plot_likert")
        clsSjpLikertFunction.AddParameter("cat.neutral", 3)
        clsSjpLikertFunction.AddParameter("coord.flip", "TRUE", iPosition:=4)
        clsSjpLikertFunction.AddParameter("catcount", "NULL", iPosition:=5)


        clsSjpStackFrqFunction.SetPackageName("sjPlot")
        clsSjpStackFrqFunction.SetRCommand("plot_stackfrq")
        clsSjpStackFrqFunction.AddParameter("show.n", "FALSE", iPosition:=3)
        clsSjpStackFrqFunction.AddParameter("coord.flip", "TRUE", iPosition:=4)
        clsSjpStackFrqFunction.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorRatingScale.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        clsSjtStackFrqFunction.SetPackageName("sjPlot")
        clsSjtStackFrqFunction.SetRCommand("tab_stackfrq")
        clsSjtStackFrqFunction.AddParameter("alternate.rows", "TRUE", iPosition:=1)
        clsSjtStackFrqFunction.AddParameter("sort.frq", "NULL", iPosition:=2)
        clsSjtStackFrqFunction.AddParameter("show.n", "TRUE", iPosition:=3)
        clsSjtStackFrqFunction.AddParameter("show.total", "TRUE", iPosition:=4)
        clsSjtStackFrqFunction.AddParameter("show.na", "TRUE", iPosition:=5)

        ucrBase.clsRsyntax.SetBaseRFunction(clsSjtStackFrqFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverWeights.AddAdditionalCodeParameterPair(clsSjpLikertFunction, ucrChkWeights.GetParameter(), iAdditionalPairNo:=1)
        ucrReceiverWeights.AddAdditionalCodeParameterPair(clsSjpStackFrqFunction, ucrChkWeights.GetParameter(), iAdditionalPairNo:=2)
        ucrChkFlip.AddAdditionalCodeParameterPair(clsSjpLikertFunction, ucrChkFlip.GetParameter(), iAdditionalPairNo:=1)
        ucrChkWeights.AddAdditionalCodeParameterPair(clsSjpLikertFunction, New RParameter("weight.by", 1), iAdditionalPairNo:=1)
        ucrChkWeights.AddAdditionalCodeParameterPair(clsSjpStackFrqFunction, New RParameter("weight.by", 1), iAdditionalPairNo:=2)
        ucrReceiverOrderedFactors.AddAdditionalCodeParameterPair(clsSjpLikertFunction, ucrReceiverOrderedFactors.GetParameter(), iAdditionalPairNo:=1)
        ucrReceiverOrderedFactors.AddAdditionalCodeParameterPair(clsSjpStackFrqFunction, ucrReceiverOrderedFactors.GetParameter(), iAdditionalPairNo:=2)
        ucrSaveGraph.AddAdditionalCodeParameterPair(clsSjpLikertFunction, ucrSaveGraph.GetParameter, iAdditionalPairNo:=1)
        ucrPnlTableOptions.AddAdditionalCodeParameterPair(clsSjpStackFrqFunction, New RParameter("sort.frq", iNewPosition:=2), iAdditionalPairNo:=1)

        ucrPnlLikertOptions.SetRCode(clsSjpLikertFunction, bReset)
        ucrPnlTableOptions.SetRCode(clsSjtStackFrqFunction, bReset)
        ucrReceiverOrderedFactors.SetRCode(clsSjtStackFrqFunction)
        ucrChkFlip.SetRCode(clsSjpStackFrqFunction, bReset)
        ucrChkWeights.SetRCode(clsSjtStackFrqFunction, bReset)
        ucrReceiverWeights.SetRCode(clsSjtStackFrqFunction, bReset)
        ucrChkNumberOfCategories.SetRCode(clsSjpLikertFunction, bReset)
        ucrPnlGraphType.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrSaveGraph.SetRCode(clsSjpStackFrqFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverOrderedFactors.IsEmpty AndAlso ucrNudNeutralLevel.GetText <> "" AndAlso (Not ucrChkWeights.Checked OrElse (ucrChkWeights.Checked AndAlso Not ucrReceiverWeights.IsEmpty)) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub NumberOfLevels()
        Dim iLevels As Integer
        If Not ucrReceiverOrderedFactors.IsEmpty AndAlso ucrSelectorRatingScale.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            If rdoLikert.Checked Then
                If ucrChkNumberOfCategories.Checked Then
                    clsSjpLikertFunction.RemoveParameterByName("cat.neutral")
                    ucrNudNeutralLevel.AddAdditionalCodeParameterPair(clsSjpLikertFunction, ucrNudNeutralLevel.GetParameter(), iAdditionalPairNo:=1)
                    clsFactorColumnFunction.AddParameter("col_name", ucrReceiverOrderedFactors.GetVariableNames())
                    clsFactorColumnFunction.AddParameter("data_name", Chr(34) & ucrSelectorRatingScale.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
                    clsAsLabelsFunction.AddParameter("x", clsRFunctionParameter:=clsFactorColumnFunction, iPosition:=0)
                    clsLevelofFactorFunction.AddParameter("x", clsRFunctionParameter:=clsAsLabelsFunction, iPosition:=0)

                    iLevels = frmMain.clsRLink.RunInternalScriptGetValue(clsLevelofFactorFunction.ToScript).AsNumeric(0)

                    'to check it its even you can do this - see if you divide by two has a remeinder 
                    If Not iLevels = 0 AndAlso iLevels < 3 Then
                        ucrChkNumberOfCategories.Checked = False
                    Else
                        ucrNudNeutralLevel.SetMinMax(1, Integer.MaxValue)
                    End If
                End If
            Else
                ucrNudNeutralLevel.SetMinMax(1, Integer.MaxValue)
            End If
        Else
            ucrNudNeutralLevel.SetMinMax(1, Integer.MaxValue)
        End If
    End Sub

    Private Sub SetBaseFunction()
        If rdoLikert.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjpLikertFunction)
            ucrBase.clsRsyntax.iCallType = 3
        ElseIf rdoStacked.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjpStackFrqFunction)
            ucrBase.clsRsyntax.iCallType = 3
        ElseIf rdoTable.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjtStackFrqFunction)
            ucrBase.clsRsyntax.iCallType = 2
        End If
    End Sub

    Private Function IsOdd(iNumb As Integer) As Boolean
        If ((iNumb >= 2 Or iNumb <= -2) AndAlso (iNumb Mod 2 <> 0)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub ucrPnlGraphType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlGraphType.ControlValueChanged
        SetBaseFunction()
        grpSort.Visible = rdoLikert.Checked
        grpSortTable.Visible = Not rdoLikert.Checked
    End Sub

    Private Sub ucrChkWeights_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkWeights.ControlValueChanged
        If ucrChkWeights.Checked Then
            ucrReceiverWeights.SetMeAsReceiver()
        Else
            ucrReceiverOrderedFactors.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrReceiverOrderedFactors_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverOrderedFactors.ControlValueChanged, ucrChkNumberOfCategories.ControlValueChanged, ucrSelectorRatingScale.ControlValueChanged, ucrPnlGraphType.ControlValueChanged
        NumberOfLevels()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNudNeutralLevel.ControlContentsChanged, ucrChkWeights.ControlContentsChanged, ucrReceiverOrderedFactors.ControlContentsChanged, ucrReceiverWeights.ControlContentsChanged, ucrPnlGraphType.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged
        TestOkEnabled()
    End Sub

End Class