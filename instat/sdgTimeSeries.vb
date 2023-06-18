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

Imports System.ComponentModel
Imports instat.Translations

Public Class sdgTimeSeries
    Private bRCodeSet As Boolean = False
    Private bControlsInitialised As Boolean = False

    Private strGeomTextReferenceParameterName As String = "reference_geom_text"
    Private strGeomTextEstimatesParameterName As String = "estimates_geom_text"
    Private strGeomTextComparisonParameterName As String = "comparison_geom_text"

    Private Const strTopLeft As String = "Top Left"
    Private Const strTopRight As String = "Top Right"
    Private Const strBottomLeft As String = "Bottom Left"
    Private Const strBottomRight As String = "Bottom Right"

    Private clsComparisonSummariesSummarise As RFunction
    Private clsIndividualSummariesSummarise As RFunction

    Private clsGgplotOperator As ROperator
    Private clsComparisonGeomText As RFunction
    Private clsReferenceGeomText As RFunction
    Private clsEstimatesGeomText As RFunction

    Private clsComparisonPasteLabel As RFunction
    Private clsReferencePasteLabel As RFunction
    Private clsEstimatesPasteLabel As RFunction

    ' A dictionary of the comparison/individual summary functions above. 
    ' The key is the summary name in lower case e.g. "bias"
    ' The value is a tuple of two RFunctions. 
    ' Item1 is the summary function. 
    ' Item2 is the paste function containing the summary.
    ' These dictionary are created to avoid passing all the RFunctions to the sub dialog individually.
    Private dctComparisonSummaries As Dictionary(Of String, Tuple(Of RFunction, RFunction))
    Private dctIndividualSummaries As Dictionary(Of String, Tuple(Of RFunction, RFunction))

    Private Sub sdgTimeSeries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        ucrPnlSummaries.AddRadioButton(rdoComparison)
        ucrPnlSummaries.AddRadioButton(rdoIndividual)

        ' Setting the conditions in this way ensures that at least one radio button is always selected as there may be no geom_text present.
        ' This set up also ensures rdoComparison is selected by default before any selection has been made.
        ucrPnlSummaries.AddParameterPresentCondition(rdoIndividual, strGeomTextReferenceParameterName)
        ucrPnlSummaries.AddParameterPresentCondition(rdoComparison, strGeomTextReferenceParameterName, bNewIsPositive:=False)

        ucrPnlSummaries.AddToLinkedControls(ucrInputPositionEstimates, {rdoIndividual}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)

        ' Individual summaries

        ucrChkNIndividual.SetText("N")
        ucrChkNIndividual.AddParameterPresentCondition(True, "n")
        ucrChkNIndividual.AddParameterPresentCondition(False, "n", bNewIsPositive:=False)

        ucrChkMeanIndividual.SetText("Mean")
        ucrChkMeanIndividual.AddParameterPresentCondition(True, "mean")
        ucrChkMeanIndividual.AddParameterPresentCondition(False, "mean", bNewIsPositive:=False)

        ucrChkSdIndividual.SetText("Sd")
        ucrChkSdIndividual.AddParameterPresentCondition(True, "sd")
        ucrChkSdIndividual.AddParameterPresentCondition(False, "sd", bNewIsPositive:=False)

        ucrChkSlopeIndividual.SetText("Slope")
        ucrChkSlopeIndividual.AddParameterPresentCondition(True, "slope")
        ucrChkSlopeIndividual.AddParameterPresentCondition(False, "slope", bNewIsPositive:=False)

        ' Comparison summaries

        ucrChkN.SetText("N")
        ucrChkN.AddParameterPresentCondition(True, "n")
        ucrChkN.AddParameterPresentCondition(False, "n", bNewIsPositive:=False)

        ucrChkCor.SetText("Cor")
        ucrChkCor.AddParameterPresentCondition(True, "cor")
        ucrChkCor.AddParameterPresentCondition(False, "cor", bNewIsPositive:=False)

        ucrChkPBias.SetText("% Bias")
        ucrChkPBias.AddParameterPresentCondition(True, "pbias")
        ucrChkPBias.AddParameterPresentCondition(False, "pbias", bNewIsPositive:=False)

        ucrChkRSd.SetText("rSD")
        ucrChkRSd.AddParameterPresentCondition(True, "rsd")
        ucrChkRSd.AddParameterPresentCondition(False, "rsd", bNewIsPositive:=False)

        ucrChkMe.SetText("ME")
        ucrChkMe.AddParameterPresentCondition(True, "me")
        ucrChkMe.AddParameterPresentCondition(False, "me", bNewIsPositive:=False)

        ucrChkMae.SetText("MAE")
        ucrChkMae.AddParameterPresentCondition(True, "mae")
        ucrChkMae.AddParameterPresentCondition(False, "mae", bNewIsPositive:=False)

        ucrChkRmse.SetText("RMSE")
        ucrChkRmse.AddParameterPresentCondition(True, "rmse")
        ucrChkRmse.AddParameterPresentCondition(False, "rmse", bNewIsPositive:=False)

        ucrChkKge.SetText("KGE")
        ucrChkKge.AddParameterPresentCondition(True, "kge")
        ucrChkKge.AddParameterPresentCondition(False, "kge", bNewIsPositive:=False)

        ucrInputPositionReference.SetItems({"Top Left", "Top Right", "Bottom Left", "Bottom Right"})
        ucrInputPositionReference.SetDropDownStyleAsNonEditable()
        ucrInputPositionReference.AddParameterValuesCondition(strTopLeft, "x", "-Inf")
        ucrInputPositionReference.AddParameterValuesCondition(strTopLeft, "y", "Inf")
        ucrInputPositionReference.AddParameterValuesCondition(strTopRight, "x", "Inf")
        ucrInputPositionReference.AddParameterValuesCondition(strTopRight, "y", "Inf")
        ucrInputPositionReference.AddParameterValuesCondition(strBottomLeft, "x", "-Inf")
        ucrInputPositionReference.AddParameterValuesCondition(strBottomLeft, "y", "-Inf")
        ucrInputPositionReference.AddParameterValuesCondition(strBottomRight, "x", "Inf")
        ucrInputPositionReference.AddParameterValuesCondition(strBottomRight, "y", "-Inf")

        ucrInputPositionEstimates.SetLinkedDisplayControl(lblPositionEstimates)
        ucrInputPositionEstimates.SetItems({"Top Left", "Top Right", "Bottom Left", "Bottom Right"})
        ucrInputPositionEstimates.SetDropDownStyleAsNonEditable()
        ucrInputPositionEstimates.AddParameterValuesCondition(strTopLeft, "x", "-Inf")
        ucrInputPositionEstimates.AddParameterValuesCondition(strTopLeft, "y", "Inf")
        ucrInputPositionEstimates.AddParameterValuesCondition(strTopRight, "x", "Inf")
        ucrInputPositionEstimates.AddParameterValuesCondition(strTopRight, "y", "Inf")
        ucrInputPositionEstimates.AddParameterValuesCondition(strBottomLeft, "x", "-Inf")
        ucrInputPositionEstimates.AddParameterValuesCondition(strBottomLeft, "y", "-Inf")
        ucrInputPositionEstimates.AddParameterValuesCondition(strBottomRight, "x", "Inf")
        ucrInputPositionEstimates.AddParameterValuesCondition(strBottomRight, "y", "-Inf")

        ucrInputSeparator.SetParameter(New RParameter("sep", iNewPosition:=8))

        ucrInputFontSize.SetParameter(New RParameter("size", iNewPosition:=8))
        ucrInputFontSize.SetValidationTypeAsNumeric()
        ucrInputFontSize.AddQuotesIfUnrecognised = False

        bControlsInitialised = True
    End Sub

    Public Sub SetRCode(clsNewComparisonSummariesSummarise As RFunction, dctNewComparisonSummaries As Dictionary(Of String, Tuple(Of RFunction, RFunction)), clsNewIndividualSummariesSummarise As RFunction, dctNewIndividualSummaries As Dictionary(Of String, Tuple(Of RFunction, RFunction)), clsNewGgplotOperator As ROperator, clsNewComparisonGeomText As RFunction, clsNewReferenceGeomText As RFunction, clsNewEstimatesGeomText As RFunction, clsNewComparisonPasteLabel As RFunction, clsNewReferencePasteLabel As RFunction, clsNewEstimatesPasteLabel As RFunction, Optional bReset As Boolean = False)
        bRCodeSet = False

        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        clsComparisonSummariesSummarise = clsNewComparisonSummariesSummarise
        dctComparisonSummaries = dctNewComparisonSummaries
        clsIndividualSummariesSummarise = clsNewIndividualSummariesSummarise
        dctIndividualSummaries = dctNewIndividualSummaries

        clsGgplotOperator = clsNewGgplotOperator
        clsComparisonGeomText = clsNewComparisonGeomText
        clsReferenceGeomText = clsNewReferenceGeomText
        clsEstimatesGeomText = clsNewEstimatesGeomText

        clsComparisonPasteLabel = clsNewComparisonPasteLabel
        clsReferencePasteLabel = clsNewReferencePasteLabel
        clsEstimatesPasteLabel = clsNewEstimatesPasteLabel

        ucrInputSeparator.AddAdditionalCodeParameterPair(clsReferencePasteLabel, New RParameter("sep", iNewPosition:=8), iAdditionalPairNo:=1)
        ucrInputSeparator.AddAdditionalCodeParameterPair(clsEstimatesPasteLabel, New RParameter("sep", iNewPosition:=8), iAdditionalPairNo:=2)

        ucrInputFontSize.AddAdditionalCodeParameterPair(clsReferenceGeomText, New RParameter("size", iNewPosition:=8), iAdditionalPairNo:=1)
        ucrInputFontSize.AddAdditionalCodeParameterPair(clsEstimatesGeomText, New RParameter("size", iNewPosition:=8), iAdditionalPairNo:=2)

        ucrPnlSummaries.SetRCode(clsGgplotOperator, bReset, bCloneIfNeeded:=True)

        ucrChkN.SetRCode(clsComparisonSummariesSummarise, bReset, bCloneIfNeeded:=True)
        ucrChkCor.SetRCode(clsComparisonSummariesSummarise, bReset, bCloneIfNeeded:=True)
        ucrChkPBias.SetRCode(clsComparisonSummariesSummarise, bReset, bCloneIfNeeded:=True)
        ucrChkRSd.SetRCode(clsComparisonSummariesSummarise, bReset, bCloneIfNeeded:=True)
        ucrChkMe.SetRCode(clsComparisonSummariesSummarise, bReset, bCloneIfNeeded:=True)
        ucrChkMae.SetRCode(clsComparisonSummariesSummarise, bReset, bCloneIfNeeded:=True)
        ucrChkRmse.SetRCode(clsComparisonSummariesSummarise, bReset, bCloneIfNeeded:=True)
        ucrChkKge.SetRCode(clsComparisonSummariesSummarise, bReset, bCloneIfNeeded:=True)

        ucrChkNIndividual.SetRCode(clsReferencePasteLabel, bReset, bCloneIfNeeded:=True)
        ucrChkMeanIndividual.SetRCode(clsReferencePasteLabel, bReset, bCloneIfNeeded:=True)
        ucrChkSdIndividual.SetRCode(clsReferencePasteLabel, bReset, bCloneIfNeeded:=True)
        ucrChkSlopeIndividual.SetRCode(clsReferencePasteLabel, bReset, bCloneIfNeeded:=True)

        ucrInputPositionReference.SetRCode(clsComparisonGeomText, bReset, bCloneIfNeeded:=True)
        ucrInputPositionEstimates.SetRCode(clsEstimatesGeomText, bReset, bCloneIfNeeded:=True)

        ucrInputSeparator.SetRCode(clsComparisonPasteLabel, bReset, bCloneIfNeeded:=True)
        ucrInputFontSize.SetRCode(clsComparisonGeomText, bReset, bCloneIfNeeded:=True)

        bRCodeSet = True
        ComparisonCheckBoxesCheck()
        IndividualCheckBoxesCheck()
        TextPosition(clsComparisonGeomText, ucrInputPositionReference.GetText())
        TextPosition(clsReferenceGeomText, ucrInputPositionReference.GetText())
        TextPosition(clsEstimatesGeomText, ucrInputPositionEstimates.GetText())
        SummariesDisplay()
    End Sub

    Private Sub ucrChkIndividual_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkNIndividual.ControlValueChanged, ucrChkMeanIndividual.ControlValueChanged, ucrChkSdIndividual.ControlValueChanged, ucrChkSlopeIndividual.ControlValueChanged
        IndividualCheckBoxesCheck()
    End Sub

    Private Sub IndividualCheckBoxesCheck()
        If bRCodeSet Then
            If rdoComparison.Checked OrElse (Not ucrChkNIndividual.Checked AndAlso Not ucrChkMeanIndividual.Checked AndAlso Not ucrChkSdIndividual.Checked AndAlso Not ucrChkSlopeIndividual.Checked) Then
                clsGgplotOperator.RemoveParameterByName(strGeomTextReferenceParameterName)
                clsGgplotOperator.RemoveParameterByName(strGeomTextEstimatesParameterName)
            Else
                clsGgplotOperator.AddParameter(strGeomTextReferenceParameterName, clsRFunctionParameter:=clsReferenceGeomText, iPosition:=4)
                clsGgplotOperator.AddParameter(strGeomTextEstimatesParameterName, clsRFunctionParameter:=clsEstimatesGeomText, iPosition:=5)
            End If
        End If
    End Sub

    Private Sub ucrChkComparison_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkN.ControlValueChanged, ucrChkCor.ControlValueChanged, ucrChkPBias.ControlValueChanged, ucrChkRSd.ControlValueChanged, ucrChkMe.ControlValueChanged, ucrChkMae.ControlValueChanged, ucrChkRmse.ControlValueChanged, ucrChkKge.ControlValueChanged
        ComparisonCheckBoxesCheck()
    End Sub

    Private Sub ComparisonCheckBoxesCheck()
        If bRCodeSet Then
            If rdoIndividual.Checked OrElse (Not ucrChkN.Checked AndAlso Not ucrChkCor.Checked AndAlso Not ucrChkPBias.Checked AndAlso Not ucrChkRSd.Checked AndAlso Not ucrChkMe.Checked AndAlso Not ucrChkMae.Checked AndAlso Not ucrChkRmse.Checked AndAlso Not ucrChkKge.Checked) Then
                clsGgplotOperator.RemoveParameterByName(strGeomTextComparisonParameterName)
            Else
                clsGgplotOperator.AddParameter(strGeomTextComparisonParameterName, clsRFunctionParameter:=clsComparisonGeomText, iPosition:=4)
            End If
        End If
    End Sub

    Private Sub ucrChkN_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkN.ControlValueChanged
        If ucrChkN.Checked Then
            clsComparisonSummariesSummarise.AddParameter("n", clsRFunctionParameter:=dctComparisonSummaries("n").Item1, iPosition:=0)
            clsComparisonPasteLabel.AddParameter("n", clsRFunctionParameter:=dctComparisonSummaries("n").Item2, iPosition:=0)
        Else
            clsComparisonSummariesSummarise.RemoveParameterByName("n")
            clsComparisonPasteLabel.RemoveParameterByName("n")
        End If
    End Sub

    Private Sub ucrChkCor_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCor.ControlValueChanged
        If ucrChkCor.Checked Then
            clsComparisonSummariesSummarise.AddParameter("cor", clsRFunctionParameter:=dctComparisonSummaries("cor").Item1, iPosition:=1)
            clsComparisonPasteLabel.AddParameter("cor", clsRFunctionParameter:=dctComparisonSummaries("cor").Item2, iPosition:=1)
        Else
            clsComparisonSummariesSummarise.RemoveParameterByName("cor")
            clsComparisonPasteLabel.RemoveParameterByName("cor")
        End If
    End Sub

    Private Sub ucrChkPBias_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPBias.ControlValueChanged
        If ucrChkPBias.Checked Then
            clsComparisonSummariesSummarise.AddParameter("pbias", clsRFunctionParameter:=dctComparisonSummaries("pbias").Item1, iPosition:=2)
            clsComparisonPasteLabel.AddParameter("pbias", clsRFunctionParameter:=dctComparisonSummaries("pbias").Item2, iPosition:=2)
        Else
            clsComparisonSummariesSummarise.RemoveParameterByName("pbias")
            clsComparisonPasteLabel.RemoveParameterByName("pbias")
        End If
    End Sub

    Private Sub ucrChkRSd_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkRSd.ControlValueChanged
        If ucrChkRSd.Checked Then
            clsComparisonSummariesSummarise.AddParameter("rsd", clsRFunctionParameter:=dctComparisonSummaries("rsd").Item1, iPosition:=3)
            clsComparisonPasteLabel.AddParameter("rsd", clsRFunctionParameter:=dctComparisonSummaries("rsd").Item2, iPosition:=3)
        Else
            clsComparisonSummariesSummarise.RemoveParameterByName("rsd")
            clsComparisonPasteLabel.RemoveParameterByName("rsd")
        End If
    End Sub

    Private Sub ucrChkMe_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMe.ControlValueChanged
        If ucrChkMe.Checked Then
            clsComparisonSummariesSummarise.AddParameter("me", clsRFunctionParameter:=dctComparisonSummaries("me").Item1, iPosition:=4)
            clsComparisonPasteLabel.AddParameter("me", clsRFunctionParameter:=dctComparisonSummaries("me").Item2, iPosition:=4)
        Else
            clsComparisonSummariesSummarise.RemoveParameterByName("me")
            clsComparisonPasteLabel.RemoveParameterByName("me")
        End If
    End Sub

    Private Sub ucrChkMae_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMae.ControlValueChanged
        If ucrChkMae.Checked Then
            clsComparisonSummariesSummarise.AddParameter("mae", clsRFunctionParameter:=dctComparisonSummaries("mae").Item1, iPosition:=5)
            clsComparisonPasteLabel.AddParameter("mae", clsRFunctionParameter:=dctComparisonSummaries("mae").Item2, iPosition:=5)
        Else
            clsComparisonSummariesSummarise.RemoveParameterByName("mae")
            clsComparisonPasteLabel.RemoveParameterByName("mae")
        End If
    End Sub

    Private Sub ucrChkRmse_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkRmse.ControlValueChanged
        If ucrChkRmse.Checked Then
            clsComparisonSummariesSummarise.AddParameter("rmse", clsRFunctionParameter:=dctComparisonSummaries("rmse").Item1, iPosition:=6)
            clsComparisonPasteLabel.AddParameter("rmse", clsRFunctionParameter:=dctComparisonSummaries("rmse").Item2, iPosition:=6)
        Else
            clsComparisonSummariesSummarise.RemoveParameterByName("rmse")
            clsComparisonPasteLabel.RemoveParameterByName("rmse")
        End If
    End Sub

    Private Sub ucrChkKge_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkKge.ControlValueChanged
        If ucrChkKge.Checked Then
            clsComparisonSummariesSummarise.AddParameter("kge", clsRFunctionParameter:=dctComparisonSummaries("kge").Item1, iPosition:=7)
            clsComparisonPasteLabel.AddParameter("kge", clsRFunctionParameter:=dctComparisonSummaries("kge").Item2, iPosition:=7)
        Else
            clsComparisonSummariesSummarise.RemoveParameterByName("kge")
            clsComparisonPasteLabel.RemoveParameterByName("kge")
        End If
    End Sub

    Private Sub ucrChkNIndividual_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkNIndividual.ControlValueChanged
        If ucrChkNIndividual.Checked Then
            clsIndividualSummariesSummarise.AddParameter("n", clsRFunctionParameter:=dctIndividualSummaries("n").Item1, iPosition:=0)
            clsReferencePasteLabel.AddParameter("n", clsRFunctionParameter:=dctIndividualSummaries("n").Item2, iPosition:=1)
            clsEstimatesPasteLabel.AddParameter("n", clsRFunctionParameter:=dctIndividualSummaries("n").Item2, iPosition:=1)
        Else
            clsIndividualSummariesSummarise.RemoveParameterByName("n")
            clsReferencePasteLabel.RemoveParameterByName("n")
            clsEstimatesPasteLabel.RemoveParameterByName("n")
        End If
    End Sub

    Private Sub ucrChkMeanIndividual_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMeanIndividual.ControlValueChanged
        If ucrChkMeanIndividual.Checked Then
            clsIndividualSummariesSummarise.AddParameter("mean", clsRFunctionParameter:=dctIndividualSummaries("mean").Item1, iPosition:=1)
            clsReferencePasteLabel.AddParameter("mean", clsRFunctionParameter:=dctIndividualSummaries("mean").Item2, iPosition:=2)
            clsEstimatesPasteLabel.AddParameter("mean", clsRFunctionParameter:=dctIndividualSummaries("mean").Item2, iPosition:=2)
        Else
            clsIndividualSummariesSummarise.RemoveParameterByName("mean")
            clsReferencePasteLabel.RemoveParameterByName("mean")
            clsEstimatesPasteLabel.RemoveParameterByName("mean")
        End If
    End Sub

    Private Sub ucrChkSdIndividual_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSdIndividual.ControlValueChanged
        If ucrChkSdIndividual.Checked Then
            clsIndividualSummariesSummarise.AddParameter("sd", clsRFunctionParameter:=dctIndividualSummaries("sd").Item1, iPosition:=2)
            clsReferencePasteLabel.AddParameter("sd", clsRFunctionParameter:=dctIndividualSummaries("sd").Item2, iPosition:=3)
            clsEstimatesPasteLabel.AddParameter("sd", clsRFunctionParameter:=dctIndividualSummaries("sd").Item2, iPosition:=3)
        Else
            clsIndividualSummariesSummarise.RemoveParameterByName("sd")
            clsReferencePasteLabel.RemoveParameterByName("sd")
            clsEstimatesPasteLabel.RemoveParameterByName("sd")
        End If
    End Sub

    Private Sub ucrChkSlopeIndividual_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSlopeIndividual.ControlValueChanged
        If ucrChkSlopeIndividual.Checked Then
            clsIndividualSummariesSummarise.AddParameter("slope", clsRFunctionParameter:=dctIndividualSummaries("slope").Item1, iPosition:=3)
            clsReferencePasteLabel.AddParameter("slope", clsRFunctionParameter:=dctIndividualSummaries("slope").Item2, iPosition:=4)
            clsEstimatesPasteLabel.AddParameter("slope", clsRFunctionParameter:=dctIndividualSummaries("slope").Item2, iPosition:=4)
        Else
            clsIndividualSummariesSummarise.RemoveParameterByName("slope")
            clsReferencePasteLabel.RemoveParameterByName("slope")
            clsEstimatesPasteLabel.RemoveParameterByName("slope")
        End If
    End Sub

    Private Sub ucrInputPosition_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputPositionReference.ControlValueChanged
        ' ucrInputPositionReference defines the position for both clsComparisonGeomText and clsReferenceGeomText hence two calls here.
        TextPosition(clsComparisonGeomText, ucrInputPositionReference.GetText())
        TextPosition(clsReferenceGeomText, ucrInputPositionReference.GetText())
    End Sub

    Private Sub ucrInputPositionEstimates_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputPositionEstimates.ControlValueChanged
        TextPosition(clsEstimatesGeomText, ucrInputPositionEstimates.GetText())
    End Sub

    ''' <summary>
    ''' Sets the x, y, hjust and vjust parameter values in clsGeomText based on the position given in strPosition.
    ''' </summary>
    ''' <param name="clsGeomText">The RFunction reprsenting the geom_text function to be updated.</param>
    ''' <param name="strPosition">The position of the text for clsGeomText, usually coming from a textbox. Must be one of the four recognised positions.</param>
    Private Sub TextPosition(clsGeomText As RFunction, strPosition As String)
        If bRCodeSet Then
            Select Case strPosition
                Case strTopLeft
                    clsGeomText.AddParameter("x", "-Inf", iPosition:=3)
                    clsGeomText.AddParameter("y", "Inf", iPosition:=4)
                    clsGeomText.AddParameter("hjust", "0", iPosition:=5)
                    clsGeomText.AddParameter("vjust", "1", iPosition:=6)
                Case strTopRight
                    clsGeomText.AddParameter("x", "Inf", iPosition:=3)
                    clsGeomText.AddParameter("y", "Inf", iPosition:=4)
                    clsGeomText.AddParameter("hjust", "1", iPosition:=5)
                    clsGeomText.AddParameter("vjust", "1", iPosition:=6)
                Case strBottomLeft
                    clsGeomText.AddParameter("x", "-Inf", iPosition:=3)
                    clsGeomText.AddParameter("y", "-Inf", iPosition:=4)
                    clsGeomText.AddParameter("hjust", "0", iPosition:=5)
                    clsGeomText.AddParameter("vjust", "0", iPosition:=6)
                Case strBottomRight
                    clsGeomText.AddParameter("x", "Inf", iPosition:=3)
                    clsGeomText.AddParameter("y", "-Inf", iPosition:=4)
                    clsGeomText.AddParameter("hjust", "1", iPosition:=5)
                    clsGeomText.AddParameter("vjust", "0", iPosition:=6)
            End Select
        End If
    End Sub

    Private Sub ucrPnlSummaries_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlSummaries.ControlValueChanged
        SummariesDisplay()
    End Sub

    ''' <summary>
    ''' Show and hide the groups boxes and adjust a label's text based on radio button selection.
    ''' </summary>
    Private Sub SummariesDisplay()
        If bRCodeSet Then
            If rdoComparison.Checked Then
                grpComparisonSummaries.Visible = True
                grpIndividualSummaries.Visible = False
                lblPositionReference.Text = GetTranslation("Position:")
            ElseIf rdoIndividual.Checked Then
                grpComparisonSummaries.Visible = False
                grpIndividualSummaries.Visible = True
                lblPositionReference.Text = GetTranslation("Position - Reference:")
            End If
            IndividualCheckBoxesCheck()
            ComparisonCheckBoxesCheck()
        End If
    End Sub

    ' In case font size is left empty, set to default value, otherwise geom_text will include 'size=' and give an error.
    Private Sub sdgTimeSeries_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If ucrInputFontSize.GetText() = "" Then
            ucrInputFontSize.SetName("5")
        End If
    End Sub
End Class