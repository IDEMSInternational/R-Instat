'' Instat-R
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
Public Class dlgExtremesClimatic
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private Sub dlgExtremesClimatic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstload Then
            InitialiseDialog()
            SetDefaults()
            bFirstload = False
        Else
            ReopenDialog()
        End If
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        'helpID
        ucrBase.iHelpTopicID = 203

        ucrReceiverData.Selector = ucrSelectorClimaticExtremes
        ucrReceiverStations.Selector = ucrSelectorClimaticExtremes
        ucrReceiverDate.Selector = ucrSelectorClimaticExtremes
        ucrReceiverYear.Selector = ucrSelectorClimaticExtremes
        ucrReceiverDOY.Selector = ucrSelectorClimaticExtremes
        ucrReceiverDate.SetMeAsReceiver()

        'ucrRdoOptions
        ucrPnlMinMaxPeaks.AddRadioButton(rdoMinMax)
        ucrPnlMinMaxPeaks.AddRadioButton(rdoPeaks)

        nudFrom.Minimum = 0
        nudTo.Minimum = 0


        'ucrchk
        ucrChkMaxima.SetText("Maxima")
        ucrChkMaxima.Checked = True
        ucrChkThreshold.SetText("Values above Threshold")
        ucrChkDayNumber.SetText("Day Number")
        ucrInputThreshhold.SetValidationTypeAsNumeric()

        'ursaveExtremes       
        ucrSaveExtremes.SetSaveTypeAsColumn()
        ucrSaveExtremes.SetDataFrameSelector(ucrSelectorClimaticExtremes.ucrAvailableDataFrames)
        ucrSaveExtremes.SetIsTextBox()
        ucrSaveExtremes.SetLabelText("New Column Name")
        ucrSaveExtremes.SetPrefix("Value")

        ucrReceiverDate.bAutoFill = True
        ucrReceiverDOY.bAutoFill = True
        ucrReceiverData.bAutoFill = True
        ucrReceiverYear.bAutoFill = True

        ucrPnlMinMaxPeaks.AddToLinkedControls(ucrInputThreshhold, {rdoPeaks}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputThreshhold.SetLinkedDisplayControl(lblThresh)
        ucrPnlMinMaxPeaks.AddToLinkedControls(ucrChkThreshold, {rdoPeaks}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMinMaxPeaks.AddToLinkedControls(ucrChkMaxima, {rdoMinMax}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        ucrSelectorClimaticExtremes.Reset()
        ucrSaveExtremes.Reset()
        ucrInputThreshhold.ResetText()
        ucrChkMaxima.Checked = True
        ucrChkDayNumber.Checked = True
        ucrChkThreshold.Checked = True
    End Sub

    Private Sub TestOkEnabled()
        If ((rdoMinMax.Checked OrElse rdoPeaks.Checked) AndAlso Not ucrReceiverStations.IsEmpty() AndAlso Not ucrReceiverYear.IsEmpty() AndAlso Not ucrReceiverDate.IsEmpty() AndAlso Not ucrReceiverDOY.IsEmpty() AndAlso Not ucrReceiverData.IsEmpty() AndAlso ucrSaveExtremes.IsComplete()) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOkEnabled()
    End Sub
End Class