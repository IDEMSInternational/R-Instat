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
    Private clsSjpLikert, clsSjpStackFrq, clsSjtStackFrq, clsLevelofFactor, clsFactorColumn, clsAsLabels As New RFunction
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

        ucrPnlTableOptions.SetParameter(New RParameter("sort.frq", iNewPosition:=6))
        ucrPnlTableOptions.AddRadioButton(rdoNoneTable, "NULL")
        ucrPnlTableOptions.AddRadioButton(rdoLowAscendingTable, Chr(34) & "last.asc" & Chr(34))
        ucrPnlTableOptions.AddRadioButton(rdoLowDescendingTable, Chr(34) & "last.desc" & Chr(34))
        ucrPnlTableOptions.AddRadioButton(rdoHighAscendingTable, Chr(34) & "first.asc" & Chr(34))
        ucrPnlTableOptions.AddRadioButton(rdoHighDescendingTable, Chr(34) & "first.desc" & Chr(34))
        ucrPnlTableOptions.SetRDefault("NULL")

        ucrPnlLikertOptions.SetParameter(New RParameter("sort.frq", iNewPosition:=6))
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

        ucrPnlGraphType.AddToLinkedControls(ucrChkFlip, {rdoLikert, rdoStacked}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
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

        'ucrPnlSortplot.likert
        rdoLikert.Enabled = True


        ucrNudNeutralLevel.SetParameter(New RParameter("cat.neutral", 7))
        ucrNudNeutralLevel.SetLinkedDisplayControl(lblNeutralLevel)

        ucrChkNumberOfCategories.SetText("Number of Categories")
        ucrChkNumberOfCategories.SetParameter(ucrNudNeutralLevel.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkNumberOfCategories.AddToLinkedControls(ucrNudNeutralLevel, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrChkNumberOfCategories.AddParameterPresentCondition(True, "cat.neutral")
        ucrChkNumberOfCategories.AddParameterPresentCondition(False, "cat.neutral", False)
        ucrChkNumberOfCategories.SetLinkedDisplayControl(grpLikertType)

        ucrChkFlip.SetParameter(New RParameter("coord.flip", 12))
        ucrChkFlip.SetText("Flip Coordinates")
        ucrChkFlip.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkFlip.SetRDefault("TRUE")

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
        clsSjtStackFrq = New RFunction
        clsSjpLikert = New RFunction
        clsSjpStackFrq = New RFunction
        clsAsLabels = New RFunction
        clsLevelofFactor = New RFunction
        clsFactorColumn = New RFunction

        rdoNoneLikert.Checked = True

        ucrSaveGraph.Reset()
        ucrSelectorRatingScale.Reset()
        ucrReceiverOrderedFactors.SetMeAsReceiver()
        ucrReceiverOrderedFactors.bForceAsDataFrame = True

        clsAsLabels.SetPackageName("sjlabelled")
        clsAsLabels.SetRCommand("as_label")

        clsLevelofFactor.SetRCommand("nlevels")

        clsFactorColumn.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")

        clsSjpLikert.SetPackageName("sjPlot")
        clsSjpLikert.SetRCommand("plot_likert")
        clsSjpLikert.AddParameter("catcount", "NULL")
        clsSjpLikert.AddParameter("cat.neutral", 7)
        clsSjpLikert.AddParameter("coord.flip", "FALSE", iPosition:=12)

        clsSjpStackFrq.SetPackageName("sjPlot")
        clsSjpStackFrq.SetRCommand("plot_stackfrq")
        clsSjpStackFrq.AddParameter("show.n", "FALSE", iPosition:=11)
        clsSjpStackFrq.AddParameter("coord.flip", "FALSE", iPosition:=12)
        clsSjpStackFrq.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorRatingScale.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        clsSjtStackFrq.SetPackageName("sjPlot")
        clsSjtStackFrq.SetRCommand("tab_stackfrq")
        clsSjtStackFrq.AddParameter("sort.frq", "NULL", iPosition:=6)
        clsSjtStackFrq.AddParameter("show.n", "TRUE", iPosition:=11)
        clsSjtStackFrq.AddParameter("show.na", "TRUE", iPosition:=13)
        clsSjtStackFrq.AddParameter("show.total", "TRUE", iPosition:=12)
        clsSjtStackFrq.AddParameter("alternate.rows", "TRUE", iPosition:=7)


        ucrBase.clsRsyntax.SetBaseRFunction(clsSjtStackFrq)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverWeights.AddAdditionalCodeParameterPair(clsSjpLikert, ucrChkWeights.GetParameter(), iAdditionalPairNo:=1)
        ucrReceiverWeights.AddAdditionalCodeParameterPair(clsSjpStackFrq, ucrChkWeights.GetParameter(), iAdditionalPairNo:=2)
        ucrChkFlip.AddAdditionalCodeParameterPair(clsSjpLikert, New RParameter("coord.flip", 12), iAdditionalPairNo:=1)
        ucrChkWeights.AddAdditionalCodeParameterPair(clsSjpLikert, New RParameter("weight.by", 2), iAdditionalPairNo:=1)
        ucrChkWeights.AddAdditionalCodeParameterPair(clsSjpStackFrq, New RParameter("weight.by", 2), iAdditionalPairNo:=2)
        ucrReceiverOrderedFactors.AddAdditionalCodeParameterPair(clsSjpLikert, ucrReceiverOrderedFactors.GetParameter(), iAdditionalPairNo:=1)
        ucrReceiverOrderedFactors.AddAdditionalCodeParameterPair(clsSjpStackFrq, ucrReceiverOrderedFactors.GetParameter(), iAdditionalPairNo:=2)
        ucrSaveGraph.AddAdditionalCodeParameterPair(clsSjpLikert, ucrSaveGraph.GetParameter, iAdditionalPairNo:=1)
        ucrPnlTableOptions.AddAdditionalCodeParameterPair(clsSjpStackFrq, New RParameter("sort.frq", iNewPosition:=6), iAdditionalPairNo:=1)

        ucrPnlLikertOptions.SetRCode(clsSjpLikert, bReset)
        ucrPnlTableOptions.SetRCode(clsSjtStackFrq, bReset)
        ucrReceiverOrderedFactors.SetRCode(clsSjtStackFrq)
        ucrChkFlip.SetRCode(clsSjpStackFrq, bReset)
        ucrChkWeights.SetRCode(clsSjtStackFrq, bReset)
        ucrReceiverWeights.SetRCode(clsSjtStackFrq, bReset)
        ucrChkNumberOfCategories.SetRCode(clsSjpLikert, bReset)
        ucrPnlGraphType.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrSaveGraph.SetRCode(clsSjpStackFrq, bReset)
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
        Dim iMedLevel As Integer
        If Not ucrReceiverOrderedFactors.IsEmpty AndAlso ucrSelectorRatingScale.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            If rdoLikert.Checked Then
                If ucrChkNumberOfCategories.Checked Then
                    clsSjpLikert.RemoveParameterByName("cat.neutral")
                    ucrNudNeutralLevel.AddAdditionalCodeParameterPair(clsSjpLikert, ucrNudNeutralLevel.GetParameter(), iAdditionalPairNo:=1)
                    clsFactorColumn.AddParameter("col_name", ucrReceiverOrderedFactors.GetVariableNames())
                    clsFactorColumn.AddParameter("data_name", Chr(34) & ucrSelectorRatingScale.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
                    clsAsLabels.AddParameter("x", clsRFunctionParameter:=clsFactorColumn)
                    clsLevelofFactor.AddParameter("x", clsRFunctionParameter:=clsAsLabels)

                    iLevels = frmMain.clsRLink.RunInternalScriptGetValue(clsLevelofFactor.ToScript).AsNumeric(0)

                    'to check it its even you can do this - see if you divide by two has a remeinder 
                    iMedLevel = (iLevels + 1) / 2
                    If Not iLevels = 0 Then
                        If IsOdd(iLevels) = True Then
                            ucrNudNeutralLevel.Visible = True
                            ucrNudNeutralLevel.Value = iMedLevel
                        Else
                            ucrNudNeutralLevel.Visible = False
                            'ucrNudNeutralLevel.Value = iLevels
                        End If
                        ucrNudNeutralLevel.SetMinMax(1, iLevels)
                    Else
                        clsSjpLikert.RemoveParameterByName("cat.neutral")
                        clsSjpLikert.AddParameter("cat.neutral", "NULL")
                        ucrNudNeutralLevel.Visible = False
                    End If
                End If
            Else
                ucrNudNeutralLevel.SetMinMax(1, Integer.MaxValue)
                ucrNudNeutralLevel.Value = 1
            End If
        Else
            ucrNudNeutralLevel.SetMinMax(1, Integer.MaxValue)
            ucrNudNeutralLevel.Value = 1
        End If
    End Sub

    Private Sub SetBaseFunction()
        If rdoLikert.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjpLikert)
            ucrBase.clsRsyntax.iCallType = 3
        ElseIf rdoStacked.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjpStackFrq)
            ucrBase.clsRsyntax.iCallType = 3
        ElseIf rdoTable.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjtStackFrq)
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

    Private Sub ucrPnlGraphType_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlGraphType.ControlValueChanged
        SetBaseFunction()
        If Not rdoLikert.Checked Then
            grpSortTable.Visible = True
            grpSort.Visible = False
        Else
            grpSort.Visible = True
            grpSortTable.Visible = False
        End If
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
        If ucrReceiverOrderedFactors.lstSelectedVariables.Items.Count > 1 Then
            ucrChkNumberOfCategories.Checked = False

        Else
            ucrChkNumberOfCategories.Checked = True
        End If
    End Sub

End Class