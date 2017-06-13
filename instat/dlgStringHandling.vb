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
Imports instat
Imports instat.Translations
Public Class dlgStringHandling
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsCountFunction, clsExtractFunction, clsDetectFunction, clsLocateFunction, clsReplaceFunction, clsReplaceAllFunction, clsFixedFunction As New RFunction
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
        ucrBase.iHelpTopicID = 406
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
        ucrPnlStringHandling.AddRadioButton(rdoReplaceAll)

        ucrPnlStringHandling.AddFunctionNamesCondition(rdoCount, "str_count")
        ucrPnlStringHandling.AddFunctionNamesCondition(rdoExtract, "str_extract")
        ucrPnlStringHandling.AddFunctionNamesCondition(rdoDetect, "str_detect")
        ucrPnlStringHandling.AddFunctionNamesCondition(rdoLocate, "str_locate")
        ucrPnlStringHandling.AddFunctionNamesCondition(rdoReplace, "str_replace")
        ucrPnlStringHandling.AddFunctionNamesCondition(rdoReplaceAll, "str_replace_all")

        ucrInputPattern.SetParameter(New RParameter("pattern", 1))
        ucrInputReplaceBy.SetParameter(New RParameter("replacement", 2))

        'disabling replaceby input text box
        ucrPnlStringHandling.AddToLinkedControls(ucrInputReplaceBy, {rdoReplace, rdoReplaceAll}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputReplaceBy.SetLinkedDisplayControl(lblReplaceBy)

        'ucrSave
        ucrSaveStringHandling.SetPrefix("count")
        ucrSaveStringHandling.SetSaveTypeAsColumn()
        ucrSaveStringHandling.SetDataFrameSelector(ucrSelectorStringHandling.ucrAvailableDataFrames)
        ucrSaveStringHandling.SetIsTextBox()
        ucrSaveStringHandling.SetLabelText("Prefix for New Column:")

        'ucrChk
        ucrChkIgnoreCase.SetText("Ignore Case")
        ucrChkIgnoreCase.AddParameterValueFunctionNamesCondition(True, "pattern", "fixed")
        ucrChkIgnoreCase.AddParameterValueFunctionNamesCondition(False, "pattern", "fixed", False)
    End Sub

    Private Sub SetDefaults()
        clsCountFunction = New RFunction
        clsExtractFunction = New RFunction
        clsDetectFunction = New RFunction
        clsLocateFunction = New RFunction
        clsReplaceFunction = New RFunction
        clsReplaceAllFunction = New RFunction
        clsFixedFunction = New RFunction

        ucrSelectorStringHandling.Reset()
        ucrInputPattern.Reset()
        ucrInputReplaceBy.Reset()
        ucrSaveStringHandling.Reset()
        ucrInputReplaceBy.SetName("")
        ucrInputPattern.SetName("")
        clsFixedFunction.SetRCommand("fixed")
        clsFixedFunction.AddParameter("ignore_case", "TRUE")

        clsCountFunction.SetPackageName("stringr")
        clsCountFunction.SetRCommand("str_count")
        clsExtractFunction.SetPackageName("stringr")
        clsExtractFunction.SetRCommand("str_extract")
        clsDetectFunction.SetPackageName("stringr")
        clsDetectFunction.SetRCommand("str_detect")
        clsLocateFunction.SetPackageName("stringr")
        clsLocateFunction.SetRCommand("str_locate")
        clsReplaceFunction.SetPackageName("stringr")
        clsReplaceFunction.SetRCommand("str_replace")
        clsReplaceAllFunction.SetPackageName("stringr")
        clsReplaceAllFunction.SetRCommand("str_replace_all")
        ChangePrefixName()
        clsCountFunction.SetAssignTo(ucrSaveStringHandling.GetText, strTempDataframe:=ucrSelectorStringHandling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveStringHandling.GetText, bAssignToIsPrefix:=True)
        ucrBase.clsRsyntax.SetBaseRFunction(clsCountFunction)
        NewColumnName()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsDetectFunction, New RParameter("string", 0), iAdditionalPairNo:=1)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsExtractFunction, New RParameter("string", 0), iAdditionalPairNo:=2)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsLocateFunction, New RParameter("string", 0), iAdditionalPairNo:=3)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsReplaceFunction, New RParameter("string", 0), iAdditionalPairNo:=4)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsReplaceAllFunction, New RParameter("string", 0), iAdditionalPairNo:=5)

        ucrInputPattern.AddAdditionalCodeParameterPair(clsDetectFunction, New RParameter("pattern", 1), iAdditionalPairNo:=1)
        ucrInputPattern.AddAdditionalCodeParameterPair(clsExtractFunction, New RParameter("pattern", 1), iAdditionalPairNo:=2)
        ucrInputPattern.AddAdditionalCodeParameterPair(clsLocateFunction, New RParameter("pattern", 1), iAdditionalPairNo:=3)
        ucrInputPattern.AddAdditionalCodeParameterPair(clsReplaceFunction, New RParameter("pattern", 1), iAdditionalPairNo:=4)
        ucrInputPattern.AddAdditionalCodeParameterPair(clsReplaceAllFunction, New RParameter("pattern", 1), iAdditionalPairNo:=5)
        ucrInputPattern.AddAdditionalCodeParameterPair(clsFixedFunction, New RParameter("pattern", 1), iAdditionalPairNo:=6)

        ucrInputReplaceBy.AddAdditionalCodeParameterPair(clsReplaceFunction, New RParameter("replacement", 2), iAdditionalPairNo:=1)

        ucrReceiverStringHandling.SetRCode(clsCountFunction, bReset)
        ucrInputPattern.SetRCode(clsCountFunction, bReset)
        ucrInputReplaceBy.SetRCode(clsReplaceFunction, bReset)
        ucrInputReplaceBy.SetRCode(clsReplaceAllFunction, bReset)
        ucrPnlStringHandling.SetRCode(clsCountFunction, bReset)
        ucrSaveStringHandling.SetRCode(clsCountFunction, bReset)
        ucrChkIgnoreCase.SetRCode(clsCountFunction, bReset)

        ucrSaveStringHandling.AddAdditionalRCode(clsDetectFunction, iAdditionalPairNo:=1)
        ucrSaveStringHandling.AddAdditionalRCode(clsExtractFunction, iAdditionalPairNo:=2)
        ucrSaveStringHandling.AddAdditionalRCode(clsLocateFunction, iAdditionalPairNo:=3)
        ucrSaveStringHandling.AddAdditionalRCode(clsReplaceFunction, iAdditionalPairNo:=4)
        ucrSaveStringHandling.AddAdditionalRCode(clsReplaceAllFunction, iAdditionalPairNo:=5)

    End Sub

    Private Sub ChangePrefixName()
        If Not ucrSaveStringHandling.bUserTyped Then
            If rdoCount.Checked Then
                ucrSaveStringHandling.SetPrefix("count")
            ElseIf rdoDetect.Checked Then
                ucrSaveStringHandling.SetPrefix("detect")
            ElseIf rdoExtract.Checked Then
                ucrSaveStringHandling.SetPrefix("extract")
            ElseIf rdoLocate.Checked Then
                ucrSaveStringHandling.SetPrefix("")
                ucrSaveStringHandling.SetName("locate")
            ElseIf rdoReplace.Checked Then
                ucrSaveStringHandling.SetPrefix("replace")
            ElseIf rdoReplaceAll.Checked Then
                ucrSaveStringHandling.SetPrefix("replace_all")
            End If
        End If
        If rdoLocate.Checked Then
            ucrSaveStringHandling.SetAssignToBooleans(bTempAssignToIsPrefix:=True)
        Else
            ucrSaveStringHandling.SetAssignToBooleans(bTempAssignToIsPrefix:=False)
        End If
    End Sub

    Private Sub NewColumnName()
        If rdoLocate.Checked Then
            ucrSaveStringHandling.SetLabelText("Prefix for New Column:")
        Else
            ucrSaveStringHandling.SetLabelText("New Column Name:")
        End If
    End Sub

    Private Sub TestOkEnabled()
        If ((rdoReplace.Checked OrElse rdoReplaceAll.Checked) AndAlso ucrSaveStringHandling.IsComplete() AndAlso Not ucrReceiverStringHandling.IsEmpty() AndAlso Not ucrInputPattern.IsEmpty AndAlso Not ucrInputReplaceBy.IsEmpty) Then
            ucrBase.OKEnabled(True)
        ElseIf (rdoCount.Checked OrElse rdoDetect.Checked OrElse rdoExtract.Checked OrElse rdoLocate.Checked) AndAlso ucrSaveStringHandling.IsComplete() AndAlso Not ucrReceiverStringHandling.IsEmpty() AndAlso Not ucrInputPattern.IsEmpty() Then
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

    Private Sub ucrPnlStringHandling_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlStringHandling.ControlValueChanged
        If rdoCount.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsCountFunction)
        ElseIf rdoDetect.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsDetectFunction)
        ElseIf rdoExtract.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsExtractFunction)
        ElseIf rdoLocate.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsLocateFunction)
        ElseIf rdoReplace.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsReplaceFunction)
        ElseIf rdoReplaceAll.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsReplaceAllFunction)
        End If
        NewColumnName()
        ChangePrefixName()
    End Sub

    Private Sub ucrReceiverStringHandling_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStringHandling.ControlContentsChanged, ucrPnlStringHandling.ControlContentsChanged, ucrInputPattern.ControlContentsChanged, ucrInputReplaceBy.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrChkIgnoreCase_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIgnoreCase.ControlValueChanged
        If ucrChkIgnoreCase.Checked Then
            clsCountFunction.AddParameter("pattern", clsRFunctionParameter:=clsFixedFunction)
            clsDetectFunction.AddParameter("pattern", clsRFunctionParameter:=clsFixedFunction)
            clsExtractFunction.AddParameter("pattern", clsRFunctionParameter:=clsFixedFunction)
            clsLocateFunction.AddParameter("pattern", clsRFunctionParameter:=clsFixedFunction)
            clsReplaceFunction.AddParameter("pattern", clsRFunctionParameter:=clsFixedFunction)
            clsReplaceAllFunction.AddParameter("pattern", clsRFunctionParameter:=clsFixedFunction)
        Else
            clsCountFunction.AddParameter("pattern", Chr(34) & ucrInputPattern.GetText & Chr(34))
            clsDetectFunction.AddParameter("pattern", Chr(34) & ucrInputPattern.GetText & Chr(34))
            clsExtractFunction.AddParameter("pattern", Chr(34) & ucrInputPattern.GetText & Chr(34))
            clsLocateFunction.AddParameter("pattern", Chr(34) & ucrInputPattern.GetText & Chr(34))
            clsReplaceFunction.AddParameter("pattern", Chr(34) & ucrInputPattern.GetText & Chr(34))
            clsReplaceAllFunction.AddParameter("pattern", Chr(34) & ucrInputPattern.GetText & Chr(34))
        End If
    End Sub
End Class