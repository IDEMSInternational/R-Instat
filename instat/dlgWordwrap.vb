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


Public Class dlgWordwrap
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsWrapFunction, clsConvertFunction, clsReplaceFunction As New RFunction
    Private bRCodeSet As Boolean = False

    Private Sub dlgWordwrap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
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
        Dim dctInputPad As New Dictionary(Of String, String)
        Dim dctInputSeparator As New Dictionary(Of String, String)

        ucrBase.iHelpTopicID = 343
        ucrBase.clsRsyntax.bUseBaseFunction = True

        'ucrReceiver
        ucrReceiverWrapText.SetParameter(New RParameter("string", 0))
        ucrReceiverWrapText.SetParameterIsRFunction()
        ucrReceiverWrapText.Selector = ucrSelectorForWrapText
        ucrReceiverWrapText.bUseFilteredData = False
        ucrReceiverWrapText.SetMeAsReceiver()
        ucrReceiverWrapText.strSelectorHeading = "Variables"

        'ucrRdoOptions
        ucrPnlTextWrap.AddRadioButton(rdoWrapText)
        ucrPnlTextWrap.AddRadioButton(rdoUnWrapText)

        ucrPnlTextWrap.AddFunctionNamesCondition(rdoWrapText, "str_wrap")
        ucrPnlTextWrap.AddFunctionNamesCondition(rdoUnWrapText, "str_replace_all")
        ucrPnlTextWrap.AddToLinkedControls(ucrNudWidthWrap, {rdoWrapText}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTextWrap.SetLinkedDisplayControl(lblOptions)

        'ucrNudWidthWrap
        ucrNudWidthWrap.SetParameter(New RParameter("width", 1))
        ucrNudWidthWrap.SetLinkedDisplayControl(lblWidthWrap)

        'ucrNewColName
        ucrNewColName.SetIsComboBox()
        ucrNewColName.SetSaveTypeAsColumn()
        ucrNewColName.SetDataFrameSelector(ucrSelectorForWrapText.ucrAvailableDataFrames)
        ucrNewColName.SetLabelText("New Column:")
        ucrNewColName.setLinkedReceiver(ucrReceiverWrapText)
    End Sub

    Private Sub SetDefaults()
        clsConvertFunction = New RFunction
        clsWrapFunction = New RFunction
        clsReplaceFunction = New RFunction

        ucrNewColName.Reset()
        ucrSelectorForWrapText.Reset()
        NewDefaultName()

        clsConvertFunction.SetPackageName("stringr")
        clsConvertFunction.SetRCommand("str_to_lower")
        clsConvertFunction.SetAssignTo(ucrNewColName.GetText(), strTempDataframe:=ucrSelectorForWrapText.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColName.GetText)

        clsReplaceFunction.SetPackageName("stringr")
        clsReplaceFunction.SetRCommand("str_replace_all")

        clsWrapFunction.SetPackageName("stringr")
        clsWrapFunction.SetRCommand("str_wrap")
        clsWrapFunction.AddParameter("width", "40", iPosition:=1)

        ucrBase.clsRsyntax.SetBaseRFunction(clsWrapFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bRCodeSet = False

        ucrReceiverWrapText.AddAdditionalCodeParameterPair(clsWrapFunction, clsNewRParameter:=New RParameter("string", 0), iAdditionalPairNo:=1)
        ucrReceiverWrapText.AddAdditionalCodeParameterPair(clsReplaceFunction, clsNewRParameter:=New RParameter("string", 0), iAdditionalPairNo:=2)

        ucrNewColName.AddAdditionalRCode(clsWrapFunction, iAdditionalPairNo:=1)
        ucrNewColName.AddAdditionalRCode(clsReplaceFunction, iAdditionalPairNo:=2)

        ucrReceiverWrapText.SetRCode(clsConvertFunction, bReset)
        ucrNewColName.SetRCode(clsConvertFunction, bReset)
        ucrPnlTextWrap.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)

        ucrNudWidthWrap.SetRCode(clsWrapFunction, bReset)

        bRCodeSet = True
    End Sub

    Private Sub TestOkEnabled()
        If rdoWrapText.Checked OrElse rdoUnWrapText.Checked Then
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

    Private Sub NewDefaultName()
        If (Not ucrNewColName.bUserTyped) AndAlso Not ucrReceiverWrapText.IsEmpty Then
            ucrNewColName.SetName(ucrReceiverWrapText.GetVariableNames(bWithQuotes:=False) & "_transformed")
        End If
    End Sub

    Private Sub ChangeBaseFunction()
        If rdoWrapText.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsWrapFunction)
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsReplaceFunction)
        End If
    End Sub

    Private Sub ucrReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverWrapText.ControlValueChanged
        NewDefaultName()
    End Sub
End Class