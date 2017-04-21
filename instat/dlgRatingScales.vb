' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.


Imports instat.Translations
Imports RDotNet
Public Class dlgRatingScales
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsSjplikert, clsSjpStackFrq, clsSjtStackFrq, clsLevelofFactor, clsFactorColumn As New RFunction
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

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverOrderedFactors.SetRCode(clsSjtStackFrq)
        ucrPnlSjpLikert.SetRCode(clsSjtStackFrq)
        ucrChkFlip.SetRCode(clsSjpStackFrq, bReset)
        ucrNudNeutralLevel.SetRCode(clsSjplikert, bReset)
        ucrReceiverWeights.SetRCode(clsSjtStackFrq, bReset)
        ucrPnlGraphType.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlType.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)

        ucrChkFlip.AddAdditionalCodeParameterPair(clsSjplikert, New RParameter("coord.flip", 3), iAdditionalPairNo:=1)
        ucrReceiverWeights.AddAdditionalCodeParameterPair(clsSjplikert, New RParameter("weight.by", 2), iAdditionalPairNo:=1)
        ucrReceiverWeights.AddAdditionalCodeParameterPair(clsSjpStackFrq, New RParameter("weight.by", 2), iAdditionalPairNo:=2)
        ucrReceiverOrderedFactors.AddAdditionalCodeParameterPair(clsSjplikert, New RParameter("items", 1), iAdditionalPairNo:=1)
        ucrReceiverOrderedFactors.AddAdditionalCodeParameterPair(clsSjpStackFrq, New RParameter("items", 1), iAdditionalPairNo:=2)
        ucrPnlSjpLikert.AddAdditionalCodeParameterPair(clsSjpStackFrq, New RParameter("sort.frq", 3), iAdditionalPairNo:=1)
        ucrPnlSjpLikert.AddAdditionalCodeParameterPair(clsSjplikert, New RParameter("sort.frq", 3), iAdditionalPairNo:=2)




    End Sub

    Private Sub SetDefaults()
        ucrReceiverOrderedFactors.SetMeAsReceiver()
        clsSjtStackFrq = New RFunction
        clsSjplikert = New RFunction
        clsSjpStackFrq = New RFunction
        ChangeOfParameters()
        ucrSelectorRatingScale.Reset()
        clsSjplikert.SetRCommand("sjp.likert")
        clsSjplikert.AddParameter("catcount", "NULL")
        'clsSjplikert.AddParameter("cat.neutral")
        clsSjplikert.AddParameter("coord.flip", "FALSE")
        clsSjpStackFrq.SetRCommand("sjp.stackfrq")
        clsSjpStackFrq.AddParameter("coord.flip", "FALSE")

        clsSjtStackFrq.SetRCommand("sjt.stackfrq")
        clsSjtStackFrq.AddParameter("sort.frq", "NULL")

        ucrBase.clsRsyntax.SetBaseRFunction(clsSjtStackFrq)
    End Sub


    Private Sub InitialiseDialog()
        ucrReceiverOrderedFactors.Selector = ucrSelectorRatingScale
        ucrReceiverWeights.Selector = ucrSelectorRatingScale

        ucrReceiverOrderedFactors.SetParameter(New RParameter("items", 1))
        ucrReceiverOrderedFactors.SetParameterIsRFunction()

        ucrReceiverWeights.SetParameter(New RParameter("weight.by", 2))
        ucrReceiverWeights.SetParameterIsRFunction()
        ucrReceiverWeights.SetDataType("numeric")

        ucrNudNeutralLevel.SetParameter(New RParameter("catcount", 4))

        ucrChkWeights.SetText("Weights")
        ucrChkWeights.SetParameter(ucrReceiverWeights.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkWeights.AddToLinkedControls(ucrReceiverWeights, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkFlip.SetText("Flip Coordinates")
        ucrChkFlip.SetParameter(New RParameter("coord.flip"))
        ucrChkFlip.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkFlip.SetRDefault("FALSE")
        ucrPnlGraphType.bAllowNonConditionValues = True
        ucrPnlType.bAllowNonConditionValues = True

        'ucrPnlSortsjp.likert
        ucrPnlSjpLikert.SetParameter(New RParameter("sort.frq", 3))
        ucrPnlSjpLikert.AddRadioButton(rdoNoneLikert, "NULL")
        ucrPnlSjpLikert.AddRadioButton(rdoLowAscendingLikert, Chr(34) & "last.asc" & Chr(34))
        ucrPnlSjpLikert.AddRadioButton(rdoLowDescendingLikert, Chr(34) & "last.desc" & Chr(34))
        ucrPnlSjpLikert.AddRadioButton(rdoHighAscendingLikert, Chr(34) & "first.asc" & Chr(34))
        ucrPnlSjpLikert.AddRadioButton(rdoHighDescendingLikert, Chr(34) & "first.desc" & Chr(34))
        ucrPnlSjpLikert.AddFunctionNamesCondition(rdoLikert, "sjPlot::sjp.likert")
        ucrPnlSjpLikert.AddFunctionNamesCondition(rdoTable, "sjPlot::sjt.stackfrq")
        ucrPnlSjpLikert.AddFunctionNamesCondition(rdoStacked, "sjPlot::sjp.stackfrq")
        ucrPnlSjpLikert.SetRDefault("NULL")

        ucrPnlGraphType.AddFunctionNamesCondition(rdoGraph, {"sjPlot::sjp.stackfrq", "sjPlot::sjp.likert"})
        ucrPnlGraphType.AddFunctionNamesCondition(rdoTable, "sjPlot::sjt.stackfrq")

        ucrPnlGraphType.AddRadioButton(rdoLikert)
        ucrPnlGraphType.AddRadioButton(rdoStacked)
        ucrPnlType.AddFunctionNamesCondition(rdoGraph, {"sjPlot::sjp.stackfrq", "sjPlot::sjp.likert"})
        ucrPnlType.AddFunctionNamesCondition(rdoTable, "sjPlot::sjt.stackfrq")

        ucrPnlType.AddRadioButton(rdoGraph)
        ucrPnlType.AddRadioButton(rdoTable)

        ucrPnlGraphType.AddToLinkedControls(ucrNudNeutralLevel, {rdoLikert}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudNeutralLevel.SetLinkedDisplayControl(lblNeutralLevel)
        'ucrPnlGraphType.AddToLinkedControls(ucrPnlSjpLikert, {rdoLikert}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoNoneLikert)

        'ucrPnlGraphType.AddToLinkedControls(ucrPnlSjpLikert, {rdoStacked}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoNoneLikert)

        ucrPnlType.AddToLinkedControls(ucrNudNeutralLevel, {rdoGraph}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudNeutralLevel.SetLinkedDisplayControl(lblNeutralLevel)
        ucrPnlGraphType.SetLinkedDisplayControl(grpGraphType)
        ucrPnlType.AddToLinkedControls(ucrPnlGraphType, {rdoGraph}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoLikert)
        'ucrPnlType.AddToLinkedControls(ucrPnlSjpLikert, {rdoTable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoNoneLikert)
        'ucrPnlSjpLikert.SetLinkedDisplayControl(grpSort)
        ucrSaveGraph.SetPrefix("Graph")
        ucrSaveGraph.SetSaveTypeAsColumn()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorRatingScale.ucrAvailableDataFrames)
        ucrSaveGraph.SetLabelText("Save Graph:")
        ucrSaveGraph.SetIsComboBox()

    End Sub

    Private Sub TestOkEnabled()
        If (Not ucrReceiverOrderedFactors.IsEmpty OrElse Not ucrReceiverWeights.IsEmpty) AndAlso ucrNudNeutralLevel.GetText <> "" AndAlso (Not ucrChkWeights.Checked OrElse (ucrChkWeights.Checked AndAlso Not ucrReceiverWeights.IsEmpty)) AndAlso (rdoGraph.Checked OrElse rdoTable.Checked) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ChangeOfParameters()

        If rdoGraph.Checked AndAlso rdoLikert.Checked Then
            clsSjtStackFrq.RemoveParameterByName("sort.frq")
            clsSjpStackFrq.RemoveParameterByName("sort.frq")
            If rdoNoneLikert.Checked Then
                clsSjplikert.AddParameter("sort.frq", "NULL")
            ElseIf rdoLowAscendingLikert.Checked Then
                clsSjplikert.AddParameter("sort.frq", Chr(34) & "neg.asc" & Chr(34))
            ElseIf rdoLowDescendingLikert.Checked Then
                clsSjplikert.AddParameter("sort.frq", Chr(34) & "neg.desc" & Chr(34))
            ElseIf rdoHighAscendingLikert.Checked Then
                clsSjplikert.AddParameter("sort.frq", Chr(34) & "posc.asc" & Chr(34))
            ElseIf rdoHighDescendingLikert.Checked Then
                clsSjplikert.AddParameter("sort.frq", Chr(34) & "posc.desc" & Chr(34))
            End If

        ElseIf rdoGraph.Checked AndAlso rdoStacked.Checked Then
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
            clsSjplikert.RemoveParameterByName("sort.frq")
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


    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        If rdoGraph.Checked Then
            If rdoLikert.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsSjplikert)
                'ucrBase.clsRsyntax.bHTMLOutput = False
            Else
                ucrBase.clsRsyntax.SetBaseRFunction(clsSjpStackFrq)
                ' ucrBase.clsRsyntax.bHTMLOutput = True
            End If
            ucrBase.clsRsyntax.iCallType = 3
        ElseIf rdoTable.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjtStackFrq)
            ucrBase.clsRsyntax.iCallType = 0
        End If
    End Sub

    Private Function IsOdd(iNumb As Integer) As Boolean
        If ((iNumb >= 2 Or iNumb <= -2) AndAlso (iNumb Mod 2 <> 0)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub NumberOfLevels()
        Dim iLevels As Integer
        Dim iMedLevel As Integer

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
    End Sub

    Private Sub ucrNudNeutralLevel_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNudNeutralLevel.ControlContentsChanged, ucrChkWeights.ControlContentsChanged, ucrReceiverOrderedFactors.ControlContentsChanged, ucrReceiverWeights.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub
    Private Sub ucrPnlType_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlType.ControlContentsChanged, ucrPnlGraphType.ControlContentsChanged, ucrPnlSjpLikert.ControlContentsChanged
        ChangeOfParameters()
    End Sub
    Private Sub ucrChkWeights_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkWeights.ControlValueChanged
        If ucrChkWeights.Checked Then
            ucrReceiverWeights.SetMeAsReceiver()
        Else
            ucrReceiverOrderedFactors.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrReceiverOrderedFactors_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverOrderedFactors.ControlValueChanged, ucrPnlGraphType.ControlValueChanged, ucrPnlType.ControlValueChanged
        If Not ucrReceiverOrderedFactors.IsEmpty AndAlso rdoGraph.Checked Then
            If rdoLikert.Checked Then
                NumberOfLevels()
            End If
        Else
            ucrNudNeutralLevel.SetMinMax(1, Integer.MaxValue)
        End If
    End Sub
End Class