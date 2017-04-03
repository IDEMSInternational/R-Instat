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
    End Sub

    Private Sub SetDefaults()
        ucrReceiverOrderedFactors.SetMeAsReceiver()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverOrderedFactors.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverWeights.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)

        ucrChkWeights.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlSjpStackFrq.SetRCode(clsSjpStackFrq, bReset)
        ucrPnlSjpLikert.SetRCode(clsSjplikert, bReset)
        ucrPnlSjtStackFrq.SetRCode(clsSjtStackFrq, bReset)

        ucrPnlGraphType.SetRCode(clsSjpStackFrq, bReset)
        ucrPnlGraphType.SetRCode(clsSjplikert, bReset)

        ucrChkFlip.SetRCode(clsSjplikert, bReset)
        ucrChkFlip.SetRCode(clsSjpStackFrq, bReset)
        ucrChkGraph.SetRCode(clsSjpStackFrq, bReset)
        ucrChkGraph.SetRCode(clsSjplikert, bReset)

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

        ucrChkGraph.SetText("Graph")
        ucrChkGraph.AddToLinkedControls(ucrPnlGraphType, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkFrequencyTable.SetText("Table")

        ucrPnlGraphType.AddRadioButton(rdoLikert)
        ucrPnlGraphType.AddRadioButton(rdoStacked)
        ucrPnlGraphType.AddToLinkedControls(ucrNudNeutralLevel, {rdoLikert}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'ucrPnlSortsjp.stackfrq
        ucrPnlSjpStackFrq.SetParameter(New RParameter("sort.frq", 2))
        ucrPnlSjpStackFrq.AddRadioButton(rdoNone, Chr(34) & "NULL" & Chr(34))
        ucrPnlSjpStackFrq.AddRadioButton(rdoLowAscending, Chr(34) & "last.asc" & Chr(34))
        ucrPnlSjpStackFrq.AddRadioButton(rdoLowDescending, Chr(34) & "last.desc" & Chr(34))
        ucrPnlSjpStackFrq.AddRadioButton(rdoHighAscending, Chr(34) & "first.asc" & Chr(34))
        ucrPnlSjpStackFrq.AddRadioButton(rdoHighDescending, Chr(34) & "first.desc" & Chr(34))
        ucrPnlSjpStackFrq.SetRDefault(Chr(34) & "NULL" & Chr(34))

        'ucrPnlSortsjt.stackfrq
        ucrPnlSjpStackFrq.SetParameter(New RParameter("sort.frq", 3))
        ucrPnlSjpStackFrq.AddRadioButton(rdoNone, Chr(34) & "NULL" & Chr(34))
        ucrPnlSjpStackFrq.AddRadioButton(rdoLowAscending, Chr(34) & "last.asc" & Chr(34))
        ucrPnlSjpStackFrq.AddRadioButton(rdoLowDescending, Chr(34) & "last.desc" & Chr(34))
        ucrPnlSjpStackFrq.AddRadioButton(rdoHighAscending, Chr(34) & "first.asc" & Chr(34))
        ucrPnlSjpStackFrq.AddRadioButton(rdoHighDescending, Chr(34) & "first.desc" & Chr(34))
        ucrPnlSjpStackFrq.SetRDefault(Chr(34) & "NULL" & Chr(34))

        'ucrPnlSortsjp.likert
        ucrPnlSjpStackFrq.SetParameter(New RParameter("sort.frq", 3))
        ucrPnlSjpStackFrq.AddRadioButton(rdoNone, Chr(34) & "NULL" & Chr(34))
        ucrPnlSjpStackFrq.AddRadioButton(rdoLowAscending, Chr(34) & "neg.asc" & Chr(34))
        ucrPnlSjpStackFrq.AddRadioButton(rdoLowDescending, Chr(34) & "neg.desc" & Chr(34))
        ucrPnlSjpStackFrq.AddRadioButton(rdoHighAscending, Chr(34) & "posc.asc" & Chr(34))
        ucrPnlSjpStackFrq.AddRadioButton(rdoHighDescending, Chr(34) & "posc.desc" & Chr(34))
        ucrPnlSjpStackFrq.SetRDefault(Chr(34) & "NULL" & Chr(34))

    End Sub

End Class