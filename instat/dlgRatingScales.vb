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
    Private clsSjpLikert, clsSjpStackFrq, clsSjtStackFrq, clsLevelofFactor, clsFactorColumn As New RFunction
    Private Sub dlgRatingScales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
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
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 519

        lblOrderedFactor.Text = "Variables:"

        ucrPnlSjpLikert.Enabled = False


        ucrPnlGraphType.AddRadioButton(rdoLikert)
        ucrPnlGraphType.AddRadioButton(rdoStacked)
        ucrPnlGraphType.AddRadioButton(rdoTable)

        ucrPnlGraphType.AddFunctionNamesCondition(rdoTable, "sjt.stackfrq")
        ucrPnlGraphType.AddFunctionNamesCondition(rdoStacked, "sjp.stackfrq")
        '  ucrPnlGraphType.AddFunctionNamesCondition(rdoLikert, "sjp.likert")

        ucrPnlGraphType.AddToLinkedControls(ucrChkFlip, {rdoLikert, rdoStacked}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGraphType.AddToLinkedControls(ucrNudNeutralLevel, {rdoLikert}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=1)
        ucrPnlGraphType.AddToLinkedControls(ucrChkNumberOfCategories, {rdoLikert}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGraphType.AddToLinkedControls(ucrSaveGraph, {rdoStacked}, bNewLinkedHideIfParameterMissing:=True)

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

        'ucrPnlSortsjp.likert
        rdoLikert.Enabled = False 'Temporary for now
        ucrPnlSjpLikert.SetParameter(New RParameter("sort.frq", 6))
        ucrPnlSjpLikert.AddRadioButton(rdoNoneLikert, "NULL")
        ucrPnlSjpLikert.AddRadioButton(rdoLowAscendingLikert, Chr(34) & "last.asc" & Chr(34))
        ucrPnlSjpLikert.AddRadioButton(rdoLowDescendingLikert, Chr(34) & "last.desc" & Chr(34))
        ucrPnlSjpLikert.AddRadioButton(rdoHighAscendingLikert, Chr(34) & "first.asc" & Chr(34))
        ucrPnlSjpLikert.AddRadioButton(rdoHighDescendingLikert, Chr(34) & "first.desc" & Chr(34))

        ucrNudNeutralLevel.SetParameter(New RParameter("catcount", 7))
        ucrNudNeutralLevel.SetLinkedDisplayControl(lblNeutralLevel)

        ucrChkNumberOfCategories.SetText("Number of Categories")
        ucrChkNumberOfCategories.SetParameter(ucrNudNeutralLevel.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkNumberOfCategories.AddToLinkedControls(ucrNudNeutralLevel, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrChkNumberOfCategories.AddParameterPresentCondition(True, "catcount")
        ucrChkNumberOfCategories.AddParameterPresentCondition(False, "catcount", False)
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

        ChangeOfParameters()
        ucrSaveGraph.Reset()
        ucrSelectorRatingScale.Reset()
        ucrReceiverOrderedFactors.SetMeAsReceiver()
        ucrReceiverOrderedFactors.bForceAsDataFrame = True

        clsSjpLikert.SetPackageName("sjPlot")
        clsSjpLikert.SetRCommand("sjp.likert")
        ' clsSjplikert.AddParameter("catcount", 1)
        'clsSjplikert.AddParameter("cat.neutral")
        clsSjpLikert.AddParameter("coord.flip", "FALSE", iPosition:=12)

        clsSjpStackFrq.SetPackageName("sjPlot")
        clsSjpStackFrq.SetRCommand("sjp.stackfrq")
        clsSjpStackFrq.AddParameter("show.n", "TRUE", iPosition:=11)
        clsSjpStackFrq.AddParameter("coord.flip", "FALSE", iPosition:=12)
        clsSjpStackFrq.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorRatingScale.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        clsSjtStackFrq.SetPackageName("sjPlot")
        clsSjtStackFrq.SetRCommand("sjt.stackfrq")
        clsSjtStackFrq.AddParameter("sort.frq", "NULL", iPosition:=6)
        clsSjtStackFrq.AddParameter("show.n", "TRUE", iPosition:=11)
        clsSjtStackFrq.AddParameter("show.na", "TRUE", iPosition:=13)
        clsSjtStackFrq.AddParameter("show.total", "TRUE", iPosition:=12)
        clsSjtStackFrq.AddParameter("altr.row.col", "TRUE", iPosition:=7)

        ucrBase.clsRsyntax.SetBaseRFunction(clsSjtStackFrq)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverWeights.AddAdditionalCodeParameterPair(clsSjpLikert, ucrChkWeights.GetParameter(), iAdditionalPairNo:=1)
        ucrReceiverWeights.AddAdditionalCodeParameterPair(clsSjpStackFrq, ucrChkWeights.GetParameter(), iAdditionalPairNo:=2)
        ucrChkFlip.AddAdditionalCodeParameterPair(clsSjpLikert, ucrChkWeights.GetParameter, iAdditionalPairNo:=1)
        ucrChkWeights.AddAdditionalCodeParameterPair(clsSjpLikert, New RParameter("weight.by", 2), iAdditionalPairNo:=1)
        ucrChkWeights.AddAdditionalCodeParameterPair(clsSjpStackFrq, New RParameter("weight.by", 2), iAdditionalPairNo:=2)
        ucrReceiverOrderedFactors.AddAdditionalCodeParameterPair(clsSjpLikert, ucrReceiverOrderedFactors.GetParameter(), iAdditionalPairNo:=1)
        ucrReceiverOrderedFactors.AddAdditionalCodeParameterPair(clsSjpStackFrq, ucrReceiverOrderedFactors.GetParameter(), iAdditionalPairNo:=2)
        ucrPnlSjpLikert.AddAdditionalCodeParameterPair(clsSjpStackFrq, New RParameter("sort.frq", 3), iAdditionalPairNo:=1)
        ucrPnlSjpLikert.AddAdditionalCodeParameterPair(clsSjpLikert, New RParameter("sort.frq", 3), iAdditionalPairNo:=2)
        ' ucrSaveGraph.AddAdditionalCodeParameterPair(clsSjplikert, ucrSaveGraph.GetParameter, iAdditionalPairNo:=1)

        ucrReceiverOrderedFactors.SetRCode(clsSjtStackFrq)
        ucrPnlSjpLikert.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkFlip.SetRCode(clsSjpStackFrq, bReset)
        ucrChkWeights.SetRCode(clsSjtStackFrq, bReset)
        ucrReceiverWeights.SetRCode(clsSjtStackFrq, bReset)
        ucrNudNeutralLevel.SetRCode(clsSjpLikert, bReset)
        ucrChkNumberOfCategories.SetRCode(clsSjpLikert, bReset)
        ucrPnlGraphType.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrSaveGraph.SetRCode(clsSjpStackFrq, bReset)
    End Sub

    Private Sub TestOkEnabled()
        'If Not ucrReceiverOrderedFactors.IsEmpty AndAlso ucrNudNeutralLevel.GetText <> "" AndAlso (Not ucrChkWeights.Checked OrElse (ucrChkWeights.Checked AndAlso Not ucrReceiverWeights.IsEmpty)) Then
        '    ucrBase.OKEnabled(True)
        'Else
        ucrBase.OKEnabled(False)
        'End If
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
                    clsLevelofFactor.SetRCommand("nlevels")
                    clsFactorColumn.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
                    clsFactorColumn.AddParameter("col_name", ucrReceiverOrderedFactors.GetVariableNames())
                    clsFactorColumn.AddParameter("data_name", Chr(34) & ucrSelectorRatingScale.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
                    clsLevelofFactor.AddParameter("x", clsRFunctionParameter:=clsFactorColumn)

                    iLevels = frmMain.clsRLink.RunInternalScriptGetValue(clsLevelofFactor.ToScript).AsNumeric(0)

                    'to check it its even you can do this - see if you divide by two has a remeinder 
                    iMedLevel = (iLevels + 1) / 2
                    If IsOdd(iLevels) = True Then
                        ucrNudNeutralLevel.Visible = True
                        ucrNudNeutralLevel.Value = iMedLevel
                    Else
                        ucrNudNeutralLevel.Visible = False
                    End If
                    ucrNudNeutralLevel.SetMinMax(1, iLevels)
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
            ucrBase.clsRsyntax.iCallType = 4
        ElseIf rdoStacked.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjpStackFrq)
            ' ucrBase.clsRsyntax.bHTMLOutput = False
            ucrBase.clsRsyntax.iCallType = 3
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjtStackFrq)
            'ucrBase.clsRsyntax.bHTMLOutput = True
            ucrBase.clsRsyntax.iCallType = 0
        End If
    End Sub

    Private Sub ChangeOfParameters()
        If rdoLikert.Checked Then
            clsSjtStackFrq.RemoveParameterByName("sort.frq")
            clsSjpStackFrq.RemoveParameterByName("sort.frq")
            If rdoNoneLikert.Checked Then
                clsSjpLikert.AddParameter("sort.frq", "NULL")
            ElseIf rdoLowAscendingLikert.Checked Then
                clsSjpLikert.AddParameter("sort.frq", Chr(34) & "neg.asc" & Chr(34))
            ElseIf rdoLowDescendingLikert.Checked Then
                clsSjpLikert.AddParameter("sort.frq", Chr(34) & "neg.desc" & Chr(34))
            ElseIf rdoHighAscendingLikert.Checked Then
                clsSjpLikert.AddParameter("sort.frq", Chr(34) & "posc.asc" & Chr(34))
            ElseIf rdoHighDescendingLikert.Checked Then
                clsSjpLikert.AddParameter("sort.frq", Chr(34) & "posc.desc" & Chr(34))
            End If
        ElseIf rdoStacked.Checked Then
            clsSjtStackFrq.RemoveParameterByName("sort.frq")
            clsSjtStackFrq.RemoveParameterByName("sort.frq")
            If rdoNoneLikert.Checked Then
                clsSjpStackFrq.AddParameter("sort.frq", "NULL")
            ElseIf rdoLowAscendingLikert.Checked Then
                clsSjpStackFrq.AddParameter("sort.frq", Chr(34) & "last.asc" & Chr(34))
            ElseIf rdoLowDescendingLikert.Checked Then
                clsSjpStackFrq.AddParameter("sort.frq", Chr(34) & "last.desc" & Chr(34))
            ElseIf rdoHighAscendingLikert.Checked Then
                clsSjpStackFrq.AddParameter("sort.frq", Chr(34) & "first.asc" & Chr(34))
            ElseIf rdoHighDescendingLikert.Checked Then
                clsSjpStackFrq.AddParameter("sort.frq", Chr(34) & "first.desc" & Chr(34))
            End If
        ElseIf rdoTable.Checked Then
            clsSjpLikert.RemoveParameterByName("sort.frq")
            clsSjpStackFrq.RemoveParameterByName("sort.frq")
            If rdoNoneLikert.Checked Then
                clsSjtStackFrq.AddParameter("sort.frq", "NULL")
            ElseIf rdoLowAscendingLikert.Checked Then
                clsSjtStackFrq.AddParameter("sort.frq", Chr(34) & "last.asc" & Chr(34))
            ElseIf rdoLowDescendingLikert.Checked Then
                clsSjtStackFrq.AddParameter("sort.frq", Chr(34) & "last.desc" & Chr(34))
            ElseIf rdoHighAscendingLikert.Checked Then
                clsSjtStackFrq.AddParameter("sort.frq", Chr(34) & "first.asc" & Chr(34))
            ElseIf rdoHighDescendingLikert.Checked Then
                clsSjtStackFrq.AddParameter("sort.frq", Chr(34) & "first.desc" & Chr(34))
            End If
        End If
    End Sub

    Private Function IsOdd(iNumb As Integer) As Boolean
        If ((iNumb >= 2 Or iNumb <= -2) AndAlso (iNumb Mod 2 <> 0)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub ucrPnlGraphType_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlGraphType.ControlValueChanged, ucrPnlSjpLikert.ControlValueChanged
        SetBaseFunction()
        ChangeOfParameters()
    End Sub

    Private Sub ucrChkWeights_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkWeights.ControlValueChanged
        If ucrChkWeights.Checked Then
            ucrReceiverWeights.SetMeAsReceiver()
        Else
            ucrReceiverOrderedFactors.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrReceiverOrderedFactors_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverOrderedFactors.ControlValueChanged, ucrChkNumberOfCategories.ControlValueChanged, ucrSelectorRatingScale.ControlValueChanged
        NumberOfLevels()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNudNeutralLevel.ControlContentsChanged, ucrChkWeights.ControlContentsChanged, ucrReceiverOrderedFactors.ControlContentsChanged, ucrReceiverWeights.ControlContentsChanged, ucrPnlGraphType.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged
        TestOkEnabled()
        'If ucrReceiverOrderedFactors.lstSelectedVariables.Items.Count > 1 Then
        '    ucrChkNumberOfCategories.Checked = False
        'Else
        '    ucrChkNumberOfCategories.Checked = True
        'End If
    End Sub

End Class