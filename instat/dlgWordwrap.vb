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
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsWrapOrUnwrapFunction As New RFunction
    Private clsAddWrapOrUnwrapColumnToDataFunction As New RFunction

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
        ucrReceiverWrapText.SetParameter(New RParameter("data", 0))
        ucrReceiverWrapText.SetParameterIsRFunction()
        ucrReceiverWrapText.Selector = ucrSelectorForWrapText
        ucrReceiverWrapText.bUseFilteredData = False
        ucrReceiverWrapText.SetMeAsReceiver()
        ucrReceiverWrapText.strSelectorHeading = "Variables"

        'ucrRdoOptions
        ucrPnlTextWrap.SetParameter(New RParameter("wrap", 2))
        ucrPnlTextWrap.AddRadioButton(rdoWrapText, "TRUE")
        ucrPnlTextWrap.AddRadioButton(rdoUnWrapText, "FALSE")

        ucrPnlTextWrap.AddParameterValuesCondition(rdoWrapText, "wrap", "TRUE")
        ucrPnlTextWrap.AddParameterValuesCondition(rdoUnWrapText, "wrap", "FALSE")
        ucrPnlTextWrap.AddToLinkedControls(ucrNudWidthWrap, {rdoWrapText}, bNewLinkedHideIfParameterMissing:=True)

        ucrNudWidthWrap.SetLinkedDisplayControl(lblWidthWrap)
        ucrNudWidthWrap.SetMinMax(1, 100)
        ucrNudWidthWrap.Increment = 1.0
    End Sub

    Private Sub SetDefaults()
        clsWrapOrUnwrapFunction = New RFunction
        clsAddWrapOrUnwrapColumnToDataFunction = New RFunction

        ucrSelectorForWrapText.Reset()
        ucrNudWidthWrap.SetText("40")

        clsWrapOrUnwrapFunction.SetRCommand("wrapOrunwrapData")
        clsWrapOrUnwrapFunction.AddParameter("width", "40", iPosition:=1)
        clsWrapOrUnwrapFunction.AddParameter("wrap", "TRUE", iPosition:=2)
        clsWrapOrUnwrapFunction.SetAssignTo("wrap_Or_unwrapData")

        clsAddWrapOrUnwrapColumnToDataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        clsAddWrapOrUnwrapColumnToDataFunction.AddParameter("col_data", clsRFunctionParameter:=clsWrapOrUnwrapFunction, iPosition:=2)
        clsAddWrapOrUnwrapColumnToDataFunction.AddParameter("before", "FALSE", iPosition:=3)

        ucrBase.clsRsyntax.SetBaseRFunction(clsAddWrapOrUnwrapColumnToDataFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverWrapText.SetRCode(clsWrapOrUnwrapFunction, bReset)
        ucrPnlTextWrap.SetRCode(clsWrapOrUnwrapFunction, bReset)
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

    Private Sub ucrReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForWrapText.ControlValueChanged, ucrReceiverWrapText.ControlValueChanged
        clsAddWrapOrUnwrapColumnToDataFunction.AddParameter("data_name", Chr(34) & ucrSelectorForWrapText.ucrAvailableDataFrames.strCurrDataFrame & Chr(34), iPosition:=0)
        clsAddWrapOrUnwrapColumnToDataFunction.AddParameter("col_name", ucrReceiverWrapText.GetVariableNames(True), iPosition:=1)
    End Sub

    Private Sub ucrPnlTextWrap_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlTextWrap.ControlValueChanged, ucrNudWidthWrap.ControlValueChanged
        If rdoWrapText.Checked Then
            clsWrapOrUnwrapFunction.AddParameter("width", ucrNudWidthWrap.GetText, iPosition:=1)
        Else
            clsWrapOrUnwrapFunction.AddParameter("width", "NULL", iPosition:=1)
        End If
    End Sub

    Private Sub ucrReceiverWrapText_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverWrapText.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        If sender Is ucrBase.cmdOk OrElse sender Is ucrBase.toolStripMenuItemOkClose OrElse sender Is ucrBase.toolStripMenuItemOkKeep Then
            frmMain.ucrDataViewer.AdjustColumnWidthAfterWrapping(ucrReceiverWrapText.GetVariableNames(False), rdoWrapText.Checked)
        End If
    End Sub
End Class