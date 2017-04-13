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
Public Class dlgRatingScales
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsSjplikert, clsSjpStackFrq, clsSjtStackFrq As New RFunction
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
        ucrReceiverOrderedFactors.SetRCode(clsSjpStackFrq)
        ucrPnlSjpLikert.SetRCode(clsSjplikert)
        ucrPnlGraphType.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ' ucrPnlGraphType.SetRCode(clsSjplikert, bReset)
        ucrPnlType.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkWeights.SetRCode(clsSjpStackFrq, bReset)
        ucrChkFlip.SetRCode(clsSjplikert, bReset)
        ucrChkFlip.SetRCode(clsSjpStackFrq, bReset)
        ' ucrPnlType.SetRCode(clsSjplikert, bReset)
        ucrNudNeutralLevel.SetRCode(clsSjplikert, bReset)
        ucrNudNeutralLevel.SetMinMax(1, Integer.MaxValue)

        ucrChkWeights.AddAdditionalCodeParameterPair(clsSjplikert, New RParameter("weight.by", 2), iAdditionalPairNo:=1)
        ucrChkWeights.AddAdditionalCodeParameterPair(clsSjtStackFrq, New RParameter("weight.by", 2), iAdditionalPairNo:=2)
        ucrReceiverOrderedFactors.AddAdditionalCodeParameterPair(clsSjplikert, New RParameter("items", 1), iAdditionalPairNo:=1)
        ucrReceiverOrderedFactors.AddAdditionalCodeParameterPair(clsSjtStackFrq, New RParameter("items", 1), iAdditionalPairNo:=2)
        ucrReceiverWeights.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlSjpLikert.AddAdditionalCodeParameterPair(clsSjpStackFrq, New RParameter("sort.frq", 3), iAdditionalPairNo:=1)
        ucrPnlSjpLikert.AddAdditionalCodeParameterPair(clsSjtStackFrq, New RParameter("sort.frq", 3), iAdditionalPairNo:=2)


    End Sub

    Private Sub SetDefaults()
        ucrReceiverOrderedFactors.SetMeAsReceiver()
        clsSjtStackFrq = New RFunction
        clsSjplikert = New RFunction
        clsSjpStackFrq = New RFunction

        ucrSelectorRatingScale.Reset()
        ucrReceiverOrderedFactors.SetParameter(New RParameter("items"))
        ucrReceiverOrderedFactors.SetParameterIsRFunction()
        clsSjplikert.SetRCommand("sjp.likert")
        clsSjplikert.AddParameter("cat.neutral")
        clsSjplikert.AddParameter("catcount", "NULL")
        clsSjplikert.AddParameter("sort.frq", "NULL")
        clsSjplikert.AddParameter("coord.flip", "FALSE")

        clsSjpStackFrq.SetRCommand("sjp.stackfrq")
        clsSjpStackFrq.AddParameter("sort.frq", "NULL")
        clsSjpStackFrq.AddParameter("coord.flip", "FALSE")

        clsSjtStackFrq.SetRCommand("sjt.stackfrq")
        clsSjtStackFrq.AddParameter("sort.frq", "NULL")

        ucrBase.clsRsyntax.SetBaseRFunction(clsSjpStackFrq)
    End Sub


    Private Sub InitialiseDialog()
        ucrReceiverOrderedFactors.Selector = ucrSelectorRatingScale
        ucrReceiverWeights.Selector = ucrSelectorRatingScale

        ucrReceiverOrderedFactors.SetParameter(New RParameter("items", 1))
        ucrReceiverOrderedFactors.SetParameterIsRFunction()

        ucrReceiverWeights.SetParameter(New RParameter("weight.by", 2))
        ucrReceiverWeights.SetParameterIsRFunction()
        ucrReceiverWeights.SetDataType("numeric")

        ucrChkWeights.SetText("Weights")
        ucrChkWeights.SetParameter(ucrReceiverWeights.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkWeights.AddToLinkedControls(ucrReceiverWeights, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkFlip.SetText("Flip Coordinates")
        ucrChkFlip.SetParameter(New RParameter("coord.flip", 1))
        ucrChkFlip.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkFlip.SetRDefault("FALSE")

        'ucrPnlSortsjt.stackfrq

        ucrPnlGraphType.bAllowNonConditionValues = True
        ucrPnlType.bAllowNonConditionValues = True

        'ucrPnlSortsjp.likert
        ucrPnlSjpLikert.AddFunctionNamesCondition(rdoLikert, "sjPlot::sjp.likert")
        ucrPnlSjpLikert.AddFunctionNamesCondition(rdoTable, "sjPlot::sjt.stackfrq")
        ucrPnlSjpLikert.AddFunctionNamesCondition(rdoStacked, "sjPlot::sjp.stackfrq")

        ucrPnlSjpLikert.SetParameter(New RParameter("sort.frq", 3))
        ucrPnlSjpLikert.AddRadioButton(rdoNoneLikert, "NULL")
        ucrPnlSjpLikert.AddRadioButton(rdoLowAscendingLikert, Chr(34) & "neg.asc" & Chr(34))
        ucrPnlSjpLikert.AddRadioButton(rdoLowDescendingLikert, Chr(34) & "neg.desc" & Chr(34))
        ucrPnlSjpLikert.AddRadioButton(rdoHighAscendingLikert, Chr(34) & "posc.asc" & Chr(34))
        ucrPnlSjpLikert.AddRadioButton(rdoHighDescendingLikert, Chr(34) & "posc.desc" & Chr(34))
        ucrPnlSjpLikert.SetRDefault("NULL")

        ucrPnlGraphType.AddFunctionNamesCondition(rdoGraph, "sjPlot::sjp.stackfrq")
        ucrPnlGraphType.AddFunctionNamesCondition(rdoGraph, "sjPlot::sjp.likert")
        ucrPnlGraphType.AddFunctionNamesCondition(rdoTable, "sjPlot::sjt.stackfrq")

        ucrPnlGraphType.AddRadioButton(rdoLikert)
        ucrPnlGraphType.AddRadioButton(rdoStacked)
        ucrPnlType.AddFunctionNamesCondition(rdoGraph, "sjPlot::sjp.stackfrq")
        ucrPnlType.AddFunctionNamesCondition(rdoGraph, "sjPlot::sjp.likert")
        ucrPnlType.AddFunctionNamesCondition(rdoTable, "sjPlot::sjt.stackfrq")
        ucrPnlType.AddRadioButton(rdoGraph)
        ucrPnlType.AddRadioButton(rdoTable)

        ucrPnlGraphType.AddToLinkedControls(ucrNudNeutralLevel, {rdoLikert}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudNeutralLevel.SetLinkedDisplayControl(lblNeutralLevel)
        ucrPnlGraphType.AddToLinkedControls(ucrPnlSjpLikert, {rdoLikert}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoNoneLikert)
        ucrPnlGraphType.AddToLinkedControls(ucrPnlSjpLikert, {rdoStacked}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoNoneLikert)
        ucrPnlType.AddToLinkedControls(ucrPnlGraphType, {rdoGraph}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlType.AddToLinkedControls(ucrPnlSjpLikert, {rdoTable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=rdoNoneLikert)

    End Sub

    Private Sub TestOkEnabled()
        If (Not ucrReceiverOrderedFactors.IsEmpty OrElse Not ucrReceiverWeights.IsEmpty) AndAlso ucrNudNeutralLevel.GetText <> "" AndAlso (Not ucrChkWeights.Checked OrElse (ucrChkWeights.Checked AndAlso Not ucrReceiverWeights.IsEmpty)) AndAlso (rdoGraph.Checked OrElse rdoTable.Checked) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
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
    Private Sub ucrNudNeutralLevel_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNudNeutralLevel.ControlContentsChanged, ucrChkWeights.ControlContentsChanged, ucrReceiverOrderedFactors.ControlContentsChanged, ucrReceiverWeights.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrChkWeights_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkWeights.ControlValueChanged
        If ucrChkWeights.Checked Then
            ucrReceiverWeights.SetMeAsReceiver()
        Else
            ucrReceiverOrderedFactors.SetMeAsReceiver()
        End If
    End Sub
End Class