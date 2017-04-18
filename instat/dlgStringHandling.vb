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
' MERCHANTABILITY or FITNESS FOR A URPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat
Imports instat.Translations

Public Class dlgStringHandling
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsCountFunction, clsExtractFunction, clsDetectFunction, clsLocateFunction, clsReplaceFunction As New RFunction
    Private Sub dlgStringHandling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        'ucrReceiver
        ucrReceiverStringHandling.SetParameter(New RParameter("string", 0))
        ucrReceiverStringHandling.SetParameterIsRFunction()
        ucrReceiverStringHandling.Selector = ucrSelectorStringHandling
        ucrReceiverStringHandling.SetMeAsReceiver()


        'ucrRdoOptions
        ucrPnlStringHandling.AddRadioButton(rdoCount)
        ucrPnlStringHandling.AddRadioButton(rdoExtract)
        ucrPnlStringHandling.AddRadioButton(rdoDetect)
        ucrPnlStringHandling.AddRadioButton(rdoLocate)
        ucrPnlStringHandling.AddRadioButton(rdoReplace)

        ucrPnlStringHandling.AddFunctionNamesCondition(rdoCount, "str_count")
        ucrPnlStringHandling.AddFunctionNamesCondition(rdoExtract, "str_extract")
        ucrPnlStringHandling.AddFunctionNamesCondition(rdoDetect, "str_detect")
        ucrPnlStringHandling.AddFunctionNamesCondition(rdoLocate, "str_locate")
        ucrPnlStringHandling.AddFunctionNamesCondition(rdoReplace, "str_replace")


        ucrInputPattern.SetParameter(New RParameter("pattern", 1))
        ucrInputReplaceBy.SetParameter(New RParameter("replacement", 2))


        'disabling replaceby input text box
        ucrPnlStringHandling.AddToLinkedControls(ucrInputReplaceBy, {rdoReplace}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)

        'ucrsave
        ucrSave.SetSaveTypeAsColumn()
        ucrSave.SetDataFrameSelector(ucrSelectorStringHandling.ucrAvailableDataFrames)
        ucrSave.SetIsComboBox()
        ucrSave.SetLabelText("Save Result to:")

    End Sub

    Private Sub SetDefaults()
        clsCountFunction = New RFunction
        clsExtractFunction = New RFunction
        clsDetectFunction = New RFunction
        clsLocateFunction = New RFunction
        clsReplaceFunction = New RFunction


        ucrSelectorStringHandling.Reset()
        ucrInputPattern.ResetText()
        ucrInputReplaceBy.ResetText()
        ucrSave.Reset()


        clsCountFunction.SetRCommand("str_count")
        clsExtractFunction.SetRCommand("str_extract")
        clsDetectFunction.SetRCommand("str_detect")
        clsLocateFunction.SetRCommand("str_locate")
        clsReplaceFunction.SetRCommand("str_replace")

        clsCountFunction.SetAssignTo(ucrSave.GetText(), strTempDataframe:=ucrSelectorStringHandling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSave.GetText)
        ucrBase.clsRsyntax.SetBaseRFunction(clsCountFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverStringHandling.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrInputPattern.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrInputReplaceBy.SetRCode(clsReplaceFunction, bReset)
        ucrPnlStringHandling.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrSave.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)

    End Sub
    Private Sub ChangeBaseFunction()
        If rdoCount.Checked Then
            ucrSave.SetPrefix("Count")
            ucrBase.clsRsyntax.SetBaseRFunction(clsCountFunction)
        ElseIf rdoDetect.Checked Then
            ucrSave.SetPrefix("detect")
            ucrBase.clsRsyntax.SetBaseRFunction(clsDetectFunction)
        ElseIf rdoExtract.Checked Then
            ucrSave.SetPrefix("extract")
            ucrBase.clsRsyntax.SetBaseRFunction(clsExtractFunction)
        ElseIf rdoLocate.Checked Then
            ucrSave.SetPrefix("locate")
            ucrBase.clsRsyntax.SetBaseRFunction(clsLocateFunction)
        ElseIf rdoReplace.Checked Then
            ucrSave.SetPrefix("replace")
            ucrBase.clsRsyntax.SetBaseRFunction(clsReplaceFunction)
        End If
    End Sub


    Private Sub TestOkEnabled()
        If rdoReplace.Checked AndAlso ucrSave.IsComplete() AndAlso Not ucrReceiverStringHandling.IsEmpty() AndAlso Not ucrInputPattern.IsEmpty AndAlso Not ucrInputReplaceBy.IsEmpty Then
            ucrBase.OKEnabled(True)
        ElseIf (rdoCount.Checked OrElse rdoDetect.Checked OrElse rdoExtract.Checked OrElse rdoLocate.Checked) AndAlso ucrSave.IsComplete() AndAlso Not ucrReceiverStringHandling.IsEmpty() AndAlso Not ucrInputPattern.IsEmpty() Then
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

    Private Sub ucrReceiverStringHandling_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStringHandling.ControlContentsChanged, ucrPnlStringHandling.ControlContentsChanged, ucrInputPattern.ControlContentsChanged, ucrInputReplaceBy.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlStringHandling_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlStringHandling.ControlValueChanged
        ChangeBaseFunction()
        'SetRCodeForControls(True)
    End Sub
End Class