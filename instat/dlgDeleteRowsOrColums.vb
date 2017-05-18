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

Imports instat
Imports instat.Translations
Public Class dlgDeleteRowsOrColums
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsOperator As New ROperator
    Private clsDeleteRows, clsDeleteColumns As RFunction
    Private Sub dlgDeleteRows_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ReopenDialog()
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 165

        ucrPnlColumnsOrRows.AddRadioButton(rdoColumns)
        ucrPnlColumnsOrRows.AddRadioButton(rdoRows)
        ucrPnlColumnsOrRows.AddFunctionNamesCondition(rdoColumns, frmMain.clsRLink.strInstatDataObject & "$remove_columns_in_data")
        ucrPnlColumnsOrRows.AddFunctionNamesCondition(rdoRows, frmMain.clsRLink.strInstatDataObject & "$remove_rows_in_data")

        ucrPnlColumnsOrRows.AddToLinkedControls(ucrReceiverForColumnsToDelete, {rdoColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrNudFrom, {rdoRows}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrNudTo, {rdoRows}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrDataFrameLengthForDeleteRows, {rdoRows}, bNewLinkedHideIfParameterMissing:=True)

        ucrSelectorForDeleteColumns.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForDeleteColumns.SetParameterIsString()

        ucrReceiverForColumnsToDelete.SetParameter(New RParameter("cols", 1))
        ucrReceiverForColumnsToDelete.Selector = ucrSelectorForDeleteColumns
        ucrReceiverForColumnsToDelete.SetMeAsReceiver()
        ucrReceiverForColumnsToDelete.SetParameterIsString()
        ucrReceiverForColumnsToDelete.SetLinkedDisplayControl(lblColumnsToDelete)
        ucrNudFrom.SetParameter(New RParameter("From", 0))
        ucrNudTo.SetParameter(New RParameter("To", 2))
        ucrNudFrom.SetMinMax(1, ucrSelectorForDeleteColumns.ucrAvailableDataFrames.iDataFrameLength)
        ucrNudFrom.SetLinkedDisplayControl(lblFrom)

        ucrNudTo.SetMinMax(1, ucrSelectorForDeleteColumns.ucrAvailableDataFrames.iDataFrameLength)
        ucrNudTo.SetLinkedDisplayControl(lblTo)

        ucrDataFrameLengthForDeleteRows.SetLinkedDisplayControl(lblNumberofRows)
        ucrDataFrameLengthForDeleteRows.SetDataFrameSelector(ucrSelectorForDeleteColumns.ucrAvailableDataFrames)
    End Sub

    Private Sub SetDefaults()
        clsDeleteColumns = New RFunction
        clsDeleteRows = New RFunction
        ucrSelectorForDeleteColumns.Reset()
        clsOperator = New ROperator

        clsOperator.SetOperation(":")
        clsDeleteRows.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_rows_in_data")
        clsDeleteColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_columns_in_data")

        clsOperator.AddParameter("From", 1, iPosition:=0)
        clsOperator.AddParameter("To", 1, iPosition:=2)

        clsDeleteRows.AddParameter("row_names", clsROperatorParameter:=clsOperator)
        ucrBase.clsRsyntax.SetBaseRFunction(clsDeleteColumns)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorForDeleteColumns.AddAdditionalCodeParameterPair(clsDeleteColumns, ucrSelectorForDeleteColumns.GetParameter, iAdditionalPairNo:=1)
        ucrPnlColumnsOrRows.SetRCode(clsDeleteRows)
        ucrPnlColumnsOrRows.SetRCode(clsDeleteColumns)
        ucrReceiverForColumnsToDelete.SetRCode(clsDeleteColumns)
        ucrSelectorForDeleteColumns.SetRCode(clsDeleteRows)
        ucrNudTo.SetRCode(clsOperator, bReset)
        ucrNudFrom.SetRCode(clsOperator, bReset)

    End Sub

    Private Sub TestOKEnabled()
        If rdoColumns.Checked Then
            If Not ucrReceiverForColumnsToDelete.IsEmpty() Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoRows.Checked Then
            If ucrNudFrom.GetText() <> "" AndAlso ucrNudTo.GetText() <> "" Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ReopenDialog()
        If ucrSelectorForDeleteColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            Try
                ucrNudFrom.Maximum = frmMain.clsRLink.GetDataFrameLength(ucrSelectorForDeleteColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
                ucrNudTo.Maximum = frmMain.clsRLink.GetDataFrameLength(ucrSelectorForDeleteColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            Catch ex As Exception
            End Try
        End If
        'temp fix to receiver containing deleted column on reopen
        ucrReceiverForColumnsToDelete.Clear()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlColumnsOrRows_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlColumnsOrRows.ControlValueChanged
        If rdoColumns.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsDeleteColumns)
            ucrSelectorForDeleteColumns.SetVariablesVisible(True)
        ElseIf rdoRows.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsDeleteRows)
            ucrSelectorForDeleteColumns.SetVariablesVisible(False)
        End If
    End Sub

    Private Sub ucrSelectorForDeleteColumns_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForDeleteColumns.ControlValueChanged
        ucrNudFrom.Maximum = ucrSelectorForDeleteColumns.ucrAvailableDataFrames.iDataFrameLength
        ucrNudTo.Maximum = ucrSelectorForDeleteColumns.ucrAvailableDataFrames.iDataFrameLength
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverForColumnsToDelete.ControlContentsChanged, ucrNudFrom.ControlContentsChanged, ucrPnlColumnsOrRows.ControlContentsChanged, ucrNudFrom.ControlContentsChanged
        TestOKEnabled()
    End Sub

End Class