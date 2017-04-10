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
    Private NULL As Integer
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
        clsSjplikert.AddParameter("catcount")
        clsSjplikert.AddParameter("sort.frq", Chr(34) & NULL & Chr(34))
        clsSjpStackFrq.SetRCommand("sjp.stackfrq")
        clsSjpStackFrq.AddParameter("sort.frq", Chr(34) & NULL & Chr(34))
        clsSjpStackFrq.AddParameter("coord.flip", "FALSE")
        clsSjtStackFrq.SetRCommand("sjt.stackfrq")
        clsSjtStackFrq.AddParameter("sort.frq", Chr(34) & NULL & Chr(34))

        ucrBase.clsRsyntax.SetBaseRFunction(clsSjpStackFrq)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverOrderedFactors.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverWeights.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)

        ucrChkWeights.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        'ucrPnlSjpStackFrq.SetRCode(clsSjpStackFrq, bReset)
        ucrPnlSjpLikert.SetRCode(clsSjplikert, bReset)
        ucrPnlSjtStackFrq.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)

        ucrPnlGraphType.SetRCode(clsSjpStackFrq, bReset)
        ucrPnlGraphType.SetRCode(clsSjplikert, bReset)
        ucrPnlType.SetRCode(clsSjtStackFrq, bReset)

        ucrChkFlip.SetRCode(clsSjplikert, bReset)
        ucrChkFlip.SetRCode(clsSjpStackFrq, bReset)
        ucrPnlType.SetRCode(clsSjpStackFrq, bReset)
        ucrPnlType.SetRCode(clsSjplikert, bReset)
        ucrNudNeutralLevel.SetRCode(clsSjplikert, bReset)


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
        ucrPnlSjtStackFrq.AddFunctionNamesCondition(rdoTable, "sjPlot::sjt.stackfrq")
        ucrPnlSjtStackFrq.AddFunctionNamesCondition(rdoStacked, "sjPlot::sjp.stackfrq")

        ucrPnlSjtStackFrq.SetParameter(New RParameter("sort.frq", 3))
        ucrPnlSjtStackFrq.AddRadioButton(rdoNone, Chr(34) & NULL & Chr(34))
        ucrPnlSjtStackFrq.AddRadioButton(rdoLowAscending, Chr(34) & "last.asc" & Chr(34))
        ucrPnlSjtStackFrq.AddRadioButton(rdoLowDescending, Chr(34) & "last.desc" & Chr(34))
        ucrPnlSjtStackFrq.AddRadioButton(rdoHighAscending, Chr(34) & "first.asc" & Chr(34))
        ucrPnlSjtStackFrq.AddRadioButton(rdoHighDescending, Chr(34) & "first.desc" & Chr(34))
        ucrPnlSjtStackFrq.SetRDefault(Chr(34) & "NULL" & Chr(34))

        'ucrPnlSortsjp.likert
        ucrPnlSjpLikert.AddFunctionNamesCondition(rdoLikert, "sjPlot::sjp.likert")
        ucrPnlSjpLikert.SetParameter(New RParameter("sort.frq", 3))
        ucrPnlSjpLikert.AddRadioButton(rdoNoneLikert, Chr(34) & NULL & Chr(34))
        ucrPnlSjpLikert.AddRadioButton(rdoLowAscendingLikert, Chr(34) & "neg.asc" & Chr(34))
        ucrPnlSjpLikert.AddRadioButton(rdoLowDescendingLikert, Chr(34) & "neg.desc" & Chr(34))
        ucrPnlSjpLikert.AddRadioButton(rdoHighAscendingLikert, Chr(34) & "posc.asc" & Chr(34))
        ucrPnlSjpLikert.AddRadioButton(rdoHighDescendingLikert, Chr(34) & "posc.desc" & Chr(34))
        ucrPnlSjpLikert.SetRDefault(Chr(34) & "NULL" & Chr(34))

        ucrPnlGraphType.AddFunctionNamesCondition(rdoGraph, "sjPlot::sjp.stackfrq")
        ucrPnlGraphType.AddFunctionNamesCondition(rdoGraph, "sjPlot::sjp.likert")
        ucrPnlGraphType.AddFunctionNamesCondition(rdoTable, "sjPlot::sjt.stackfrq")

        ucrPnlGraphType.AddRadioButton(rdoLikert)
        ucrPnlGraphType.AddRadioButton(rdoStacked)
        ucrPnlType.AddRadioButton(rdoGraph)
        ucrPnlType.AddRadioButton(rdoTable)

        ucrPnlGraphType.AddToLinkedControls(ucrNudNeutralLevel, {rdoLikert}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudNeutralLevel.SetLinkedDisplayControl(lblNeutralLevel)

        ucrPnlGraphType.AddToLinkedControls(ucrPnlSjpLikert, {rdoLikert}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGraphType.AddToLinkedControls(ucrPnlSjtStackFrq, {rdoStacked}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlType.AddToLinkedControls(ucrPnlGraphType, {rdoGraph}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlType.AddToLinkedControls(ucrPnlSjtStackFrq, {rdoTable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

    End Sub

    Private Sub TestOkEnabled()
        If (Not ucrReceiverOrderedFactors.IsEmpty OrElse Not ucrReceiverWeights.IsEmpty) AndAlso ucrNudNeutralLevel.GetText <> "" AndAlso (Not ucrChkWeights.Checked OrElse (ucrChkWeights.Checked AndAlso Not ucrReceiverWeights.IsEmpty)) AndAlso (rdoGraph.Checked OrElse rdoTable.Checked) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ChangeBaseFunction()
        If rdoGraph.Checked Then
            If rdoLikert.Checked Then
                ucrPnlSjpLikert.SetParameter(New RParameter("sort.frq", 2))
                ucrNudNeutralLevel.SetParameter(New RParameter("cat.neutral", 3))
                ucrBase.clsRsyntax.SetBaseRFunction(clsSjplikert)
            Else
                ucrPnlSjtStackFrq.SetParameter(New RParameter("sort.frq", 2))
                ucrBase.clsRsyntax.SetBaseRFunction(clsSjpStackFrq)
            End If
        ElseIf rdoTable.Checked Then
            ucrPnlSjtStackFrq.SetParameter(New RParameter("sort.frq", 2))
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjtStackFrq)
        End If
        SetRCodeForControls(False)
    End Sub


    Private Sub ucrNudNeutralLevel_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNudNeutralLevel.ControlContentsChanged, ucrChkWeights.ControlContentsChanged, ucrReceiverOrderedFactors.ControlContentsChanged, ucrReceiverWeights.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ICalltype()
        If rdoGraph.Checked AndAlso (rdoLikert.Checked OrElse rdoStacked.Checked) Then
            ucrBase.clsRsyntax.iCallType = 3
        ElseIf rdoTable.Checked Then
            ucrBase.clsRsyntax.iCallType = 0
        End If

    End Sub


    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrChkGraph_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlGraphType.ControlContentsChanged, ucrPnlType.ControlContentsChanged
        ChangeBaseFunction()
        ICalltype()
    End Sub

End Class