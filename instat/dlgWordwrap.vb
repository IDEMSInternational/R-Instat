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
    Private clsWrapFunction, clsReplaceFunction As New RFunction
    Private clsAddColumnToDataFunction As New RFunction

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

        'ucrNudWidthWrap
        ucrNudWidthWrap.SetParameter(New RParameter("width", 1))
        ucrNudWidthWrap.SetLinkedDisplayControl(lblWidthWrap)

    End Sub

    Private Sub SetDefaults()
        clsWrapFunction = New RFunction
        clsReplaceFunction = New RFunction
        clsAddColumnToDataFunction = New RFunction

        ucrSelectorForWrapText.Reset()

        clsReplaceFunction.SetPackageName("stringr")
        clsReplaceFunction.SetRCommand("str_replace_all")
        clsReplaceFunction.AddParameter("pattern", Chr(34) & "\n" & Chr(34), iPosition:=2)
        clsReplaceFunction.AddParameter("replacement", Chr(34) & " " & Chr(34), iPosition:=3)
        clsReplaceFunction.SetAssignTo("unwrap_column")

        clsWrapFunction.SetPackageName("stringr")
        clsWrapFunction.SetRCommand("str_wrap")
        clsWrapFunction.AddParameter("width", "40", iPosition:=1)
        clsWrapFunction.SetAssignTo("wrap_column")

        clsAddColumnToDataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        clsAddColumnToDataFunction.AddParameter("col_data", clsRFunctionParameter:=clsWrapFunction, iPosition:=2)
        clsAddColumnToDataFunction.AddParameter("before", "FALSE", iPosition:=3)

        ucrBase.clsRsyntax.SetBaseRFunction(clsWrapFunction)
        ucrBase.clsRsyntax.AddToAfterCodes(clsAddColumnToDataFunction, 0)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)

        ucrReceiverWrapText.AddAdditionalCodeParameterPair(clsReplaceFunction, clsNewRParameter:=New RParameter("string", 0), iAdditionalPairNo:=1)

        ucrSelectorForWrapText.SetRCode(clsAddColumnToDataFunction, bReset)
        ucrReceiverWrapText.SetRCode(clsWrapFunction, bReset)

        ucrPnlTextWrap.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)

        ucrNudWidthWrap.SetRCode(clsWrapFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverWrapText.IsEmpty Then
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

    Private Sub ucrReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverWrapText.ControlValueChanged, ucrSelectorForWrapText.ControlValueChanged
        clsAddColumnToDataFunction.AddParameter("data_name", Chr(34) & ucrSelectorForWrapText.ucrAvailableDataFrames.strCurrDataFrame & Chr(34), iPosition:=0)
        clsAddColumnToDataFunction.AddParameter("col_name", ucrReceiverWrapText.GetVariableNames(True), iPosition:=1)
    End Sub

    Private Sub ucrPnlTextWrap_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlTextWrap.ControlValueChanged
        If rdoWrapText.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsWrapFunction)
            clsAddColumnToDataFunction.AddParameter("col_data", clsRFunctionParameter:=clsWrapFunction, iPosition:=2)
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsReplaceFunction)
            clsAddColumnToDataFunction.AddParameter("col_data", clsRFunctionParameter:=clsReplaceFunction, iPosition:=2)
        End If
    End Sub

    Private Sub ucrReceiverWrapText_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverWrapText.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        If rdoUnWrapText.Checked Then
            frmMain.ucrDataViewer.ResetGridRowHeightAndColumnWidth(ucrSelectorForWrapText.strCurrentDataFrame)
        End If
    End Sub
End Class