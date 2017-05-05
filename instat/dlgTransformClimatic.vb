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
Public Class dlgTransformClimatic
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsSumFunction, clsCountFunction, clsSpellFunction, clsWaterBalanceFunction As New RFunction
    Private Sub dlgTransformClimatic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverStation.Selector = ucrSelectorTransform
        ucrReceiverYear.Selector = ucrSelectorTransform
        ucrReceiverDate.Selector = ucrSelectorTransform
        ucrReceiverDOY.Selector = ucrSelectorTransform
        ucrReceiverData.Selector = ucrSelectorTransform
        ucrReceiverDate.SetMeAsReceiver()
        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDOY.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        'this is not right
        ucrReceiverData.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "rain" & Chr(34)})
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverStation.bAutoFill = True
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDOY.bAutoFill = True
        ucrReceiverData.bAutoFill = True
        ucrReceiverYear.bAutoFill = True

        ucrPnlTransform.AddRadioButton(rdoSum)
        ucrPnlTransform.AddRadioButton(rdoCount)
        ucrPnlTransform.AddRadioButton(rdoSpell)
        ucrPnlTransform.AddRadioButton(rdoWaterBalance)

        ucrPnlTransform.AddFunctionNamesCondition(rdoSum, "")
        ucrPnlTransform.AddFunctionNamesCondition(rdoCount, "")
        ucrPnlTransform.AddFunctionNamesCondition(rdoSpell, "")
        ucrPnlTransform.AddFunctionNamesCondition(rdoWaterBalance, "")

        ucrSaveTransform.SetDataFrameSelector(ucrSelectorTransform.ucrAvailableDataFrames)
        ucrSaveTransform.SetLabelText("New Column Name:")
        ucrSaveTransform.SetIsTextBox()
        ucrSaveTransform.SetPrefix("Sum")
        ucrSaveTransform.SetSaveTypeAsColumn()
    End Sub

    Private Sub SetDefaults()
        clsSumFunction = New RFunction
        clsCountFunction = New RFunction
        clsSpellFunction = New RFunction
        clsWaterBalanceFunction = New RFunction
        ucrSaveTransform.Reset()
        ucrSelectorTransform.Reset()

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)

    End Sub

    Private Sub TestOkEnabled()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

End Class