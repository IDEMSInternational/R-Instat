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

Public Class sdgTimeSeries
    Private bRCodeSet As Boolean = False
    Private bControlsInitialised As Boolean = False

    Private strGeomTextParameterName As String = "geom_text"

    Private strTopLeft As String = "Top Left"
    Private strTopRight As String = "Top Right"
    Private strBottomLeft As String = "Bottom Left"
    Private strBottomRight As String = "Bottom Right"

    Private clsSummarise As RFunction

    Private clsGgplotOperator As ROperator
    Private clsGeomText As RFunction
    Private clsPasteLabel As RFunction

    Private dctSummaries As Dictionary(Of String, Tuple(Of RFunction, RFunction))

    Private Sub sdgTimeSeries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
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

        ucrInputPosition.SetItems({"Top Left", "Top Right", "Bottom Left", "Bottom Right"})
        ucrInputPosition.SetDropDownStyleAsNonEditable()
        ucrInputPosition.AddParameterValuesCondition(strTopLeft, "x", "-Inf")
        ucrInputPosition.AddParameterValuesCondition(strTopLeft, "y", "Inf")
        ucrInputPosition.AddParameterValuesCondition(strTopRight, "x", "Inf")
        ucrInputPosition.AddParameterValuesCondition(strTopRight, "y", "Inf")
        ucrInputPosition.AddParameterValuesCondition(strBottomLeft, "x", "-Inf")
        ucrInputPosition.AddParameterValuesCondition(strBottomLeft, "y", "-Inf")
        ucrInputPosition.AddParameterValuesCondition(strBottomRight, "x", "Inf")
        ucrInputPosition.AddParameterValuesCondition(strBottomRight, "y", "-Inf")

        ucrInputSeparator.SetParameter(New RParameter("sep", iNewPosition:=8))

        ucrInputFontSize.SetParameter(New RParameter("size", iNewPosition:=8))
        ucrInputFontSize.SetValidationTypeAsNumeric()
        ucrInputFontSize.AddQuotesIfUnrecognised = False

    End Sub

    Public Sub SetRCode(clsNewSummarise As RFunction, dctNewSummaries As Dictionary(Of String, Tuple(Of RFunction, RFunction)), clsNewGgplotOperator As ROperator, clsNewGeomText As RFunction, clsNewPasteLabel As RFunction, Optional bReset As Boolean = False)
        bRCodeSet = False

        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        clsSummarise = clsNewSummarise
        dctSummaries = dctNewSummaries
        clsGgplotOperator = clsNewGgplotOperator
        clsGeomText = clsNewGeomText
        clsPasteLabel = clsNewPasteLabel

        ucrChkN.SetRCode(clsSummarise, bReset, bCloneIfNeeded:=True)
        ucrChkCor.SetRCode(clsSummarise, bReset, bCloneIfNeeded:=True)
        ucrChkPBias.SetRCode(clsSummarise, bReset, bCloneIfNeeded:=True)
        ucrChkRSd.SetRCode(clsSummarise, bReset, bCloneIfNeeded:=True)
        ucrChkMe.SetRCode(clsSummarise, bReset, bCloneIfNeeded:=True)
        ucrChkMae.SetRCode(clsSummarise, bReset, bCloneIfNeeded:=True)
        ucrChkRmse.SetRCode(clsSummarise, bReset, bCloneIfNeeded:=True)
        ucrChkKge.SetRCode(clsSummarise, bReset, bCloneIfNeeded:=True)

        ucrInputPosition.SetRCode(clsGeomText, bReset, bCloneIfNeeded:=True)
        ucrInputSeparator.SetRCode(clsPasteLabel, bReset, bCloneIfNeeded:=True)
        ucrInputFontSize.SetRCode(clsGeomText, bReset, bCloneIfNeeded:=True)

        bRCodeSet = True
        CheckBoxesCheck()
        TextPosition()
    End Sub

    Private Sub ucrChk_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkN.ControlValueChanged, ucrChkCor.ControlValueChanged, ucrChkPBias.ControlValueChanged, ucrChkRSd.ControlValueChanged, ucrChkMe.ControlValueChanged, ucrChkMae.ControlValueChanged, ucrChkRmse.ControlValueChanged, ucrChkKge.ControlValueChanged
        CheckBoxesCheck()
    End Sub

    Private Sub CheckBoxesCheck()
        If bRCodeSet Then
            If Not ucrChkN.Checked AndAlso Not ucrChkCor.Checked AndAlso Not ucrChkPBias.Checked AndAlso Not ucrChkRSd.Checked AndAlso Not ucrChkMe.Checked AndAlso Not ucrChkMae.Checked AndAlso Not ucrChkRmse.Checked AndAlso Not ucrChkKge.Checked Then
                clsGgplotOperator.RemoveParameterByName(strGeomTextParameterName)
            Else
                clsGgplotOperator.AddParameter(strGeomTextParameterName, clsRFunctionParameter:=clsGeomText, iPosition:=4)
            End If
        End If
    End Sub

    Private Sub ucrChkN_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkN.ControlValueChanged
        If ucrChkN.Checked Then
            clsSummarise.AddParameter("n", clsRFunctionParameter:=dctSummaries("n").Item1, iPosition:=0)
            clsPasteLabel.AddParameter("n", clsRFunctionParameter:=dctSummaries("n").Item2, iPosition:=0)
        Else
            clsSummarise.RemoveParameterByName("n")
            clsPasteLabel.RemoveParameterByName("n")
        End If
    End Sub

    Private Sub ucrChkCor_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCor.ControlValueChanged
        If ucrChkCor.Checked Then
            clsSummarise.AddParameter("cor", clsRFunctionParameter:=dctSummaries("cor").Item1, iPosition:=1)
            clsPasteLabel.AddParameter("cor", clsRFunctionParameter:=dctSummaries("cor").Item2, iPosition:=1)
        Else
            clsSummarise.RemoveParameterByName("cor")
            clsPasteLabel.RemoveParameterByName("cor")
        End If
    End Sub

    Private Sub ucrChkPBias_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPBias.ControlValueChanged
        If ucrChkPBias.Checked Then
            clsSummarise.AddParameter("pbias", clsRFunctionParameter:=dctSummaries("pbias").Item1, iPosition:=2)
            clsPasteLabel.AddParameter("pbias", clsRFunctionParameter:=dctSummaries("pbias").Item2, iPosition:=2)
        Else
            clsSummarise.RemoveParameterByName("pbias")
            clsPasteLabel.RemoveParameterByName("pbias")
        End If
    End Sub

    Private Sub ucrChkRSd_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkRSd.ControlValueChanged
        If ucrChkRSd.Checked Then
            clsSummarise.AddParameter("rsd", clsRFunctionParameter:=dctSummaries("rsd").Item1, iPosition:=3)
            clsPasteLabel.AddParameter("rsd", clsRFunctionParameter:=dctSummaries("rsd").Item2, iPosition:=3)
        Else
            clsSummarise.RemoveParameterByName("rsd")
            clsPasteLabel.RemoveParameterByName("rsd")
        End If
    End Sub

    Private Sub ucrChkMe_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMe.ControlValueChanged
        If ucrChkMe.Checked Then
            clsSummarise.AddParameter("me", clsRFunctionParameter:=dctSummaries("me").Item1, iPosition:=4)
            clsPasteLabel.AddParameter("me", clsRFunctionParameter:=dctSummaries("me").Item2, iPosition:=4)
        Else
            clsSummarise.RemoveParameterByName("me")
            clsPasteLabel.RemoveParameterByName("me")
        End If
    End Sub

    Private Sub ucrChkMae_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMae.ControlValueChanged
        If ucrChkMae.Checked Then
            clsSummarise.AddParameter("mae", clsRFunctionParameter:=dctSummaries("mae").Item1, iPosition:=5)
            clsPasteLabel.AddParameter("mae", clsRFunctionParameter:=dctSummaries("mae").Item2, iPosition:=5)
        Else
            clsSummarise.RemoveParameterByName("mae")
            clsPasteLabel.RemoveParameterByName("mae")
        End If
    End Sub

    Private Sub ucrChkRmse_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkRmse.ControlValueChanged
        If ucrChkRmse.Checked Then
            clsSummarise.AddParameter("rmse", clsRFunctionParameter:=dctSummaries("rmse").Item1, iPosition:=6)
            clsPasteLabel.AddParameter("rmse", clsRFunctionParameter:=dctSummaries("rmse").Item2, iPosition:=6)
        Else
            clsSummarise.RemoveParameterByName("rmse")
            clsPasteLabel.RemoveParameterByName("rmse")
        End If
    End Sub

    Private Sub ucrChkKge_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkKge.ControlValueChanged
        If ucrChkKge.Checked Then
            clsSummarise.AddParameter("kge", clsRFunctionParameter:=dctSummaries("kge").Item1, iPosition:=7)
            clsPasteLabel.AddParameter("kge", clsRFunctionParameter:=dctSummaries("kge").Item2, iPosition:=7)
        Else
            clsSummarise.RemoveParameterByName("kge")
            clsPasteLabel.RemoveParameterByName("kge")
        End If
    End Sub

    Private Sub ucrInputPosition_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputPosition.ControlValueChanged
        TextPosition()
    End Sub

    Private Sub TextPosition()
        If bRCodeSet Then
            If ucrInputPosition.GetText() = strTopLeft Then
                clsGeomText.AddParameter("x", "-Inf", iPosition:=3)
                clsGeomText.AddParameter("y", "Inf", iPosition:=4)
                clsGeomText.AddParameter("hjust", "0", iPosition:=5)
                clsGeomText.AddParameter("vjust", "1", iPosition:=6)
            ElseIf ucrInputPosition.GetText() = strTopRight Then
                clsGeomText.AddParameter("x", "Inf", iPosition:=3)
                clsGeomText.AddParameter("y", "Inf", iPosition:=4)
                clsGeomText.AddParameter("hjust", "1", iPosition:=5)
                clsGeomText.AddParameter("vjust", "1", iPosition:=6)
            ElseIf ucrInputPosition.GetText() = strBottomLeft Then
                clsGeomText.AddParameter("x", "-Inf", iPosition:=3)
                clsGeomText.AddParameter("y", "-Inf", iPosition:=4)
                clsGeomText.AddParameter("hjust", "0", iPosition:=5)
                clsGeomText.AddParameter("vjust", "0", iPosition:=6)
            ElseIf ucrInputPosition.GetText() = strBottomRight Then
                clsGeomText.AddParameter("x", "Inf", iPosition:=3)
                clsGeomText.AddParameter("y", "-Inf", iPosition:=4)
                clsGeomText.AddParameter("hjust", "1", iPosition:=5)
                clsGeomText.AddParameter("vjust", "0", iPosition:=6)
            End If
        End If
    End Sub
End Class