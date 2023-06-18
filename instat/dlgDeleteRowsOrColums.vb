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
Public Class dlgDeleteRowsOrColums
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsOperatorRowNames As New ROperator
    Private clsDeleteRows, clsDeleteColumns As RFunction
    Private clsRemoveEmptyColumns, clsConcFunction As New RFunction
    Private clsDummyFunction As New RFunction
    Private Sub dlgDeleteRows_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 165
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrPnlColumnsOrRows.AddRadioButton(rdoColumns)
        ucrPnlColumnsOrRows.AddRadioButton(rdoRows)
        ucrPnlColumnsOrRows.AddRadioButton(rdoEmpty)
        ucrPnlColumnsOrRows.AddParameterValuesCondition(rdoColumns, "checked", "columns")
        ucrPnlColumnsOrRows.AddParameterValuesCondition(rdoRows, "checked", "rows")
        ucrPnlColumnsOrRows.AddParameterValuesCondition(rdoEmpty, "checked", "empty")

        ucrPnlColumnsOrRows.AddToLinkedControls(ucrReceiverForColumnsToDelete, {rdoColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrNudFrom, {rdoRows}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrNudTo, {rdoRows}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrDataFrameLengthForDeleteRows, {rdoRows}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls({ucrChkEmptyRows, ucrChkEmptyColumns}, {rdoEmpty}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrSelectorForDeleteColumns.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForDeleteColumns.SetParameterIsString()

        ucrReceiverForColumnsToDelete.SetParameter(New RParameter("cols", 1))
        ucrReceiverForColumnsToDelete.Selector = ucrSelectorForDeleteColumns
        ucrReceiverForColumnsToDelete.SetMeAsReceiver()
        ucrReceiverForColumnsToDelete.SetParameterIsString()
        ucrReceiverForColumnsToDelete.SetLinkedDisplayControl(lblColumnsToDelete)

        ucrNudFrom.SetParameter(New RParameter("From", 0))
        ucrNudFrom.SetLinkedDisplayControl(lblFrom)

        ucrNudTo.SetParameter(New RParameter("To", 1))
        ucrNudTo.SetLinkedDisplayControl(lblTo)

        ucrChkEmptyColumns.SetText("Columns")
        ucrChkEmptyColumns.AddParameterPresentCondition(True, "x")
        ucrChkEmptyColumns.AddParameterPresentCondition(False, "x", False)

        ucrChkEmptyRows.SetText("Rows")
        ucrChkEmptyRows.AddParameterPresentCondition(True, "y")
        ucrChkEmptyRows.AddParameterPresentCondition(False, "y", False)

        ucrDataFrameLengthForDeleteRows.SetLinkedDisplayControl(lblNumberofRows)
        ucrDataFrameLengthForDeleteRows.SetDataFrameSelector(ucrSelectorForDeleteColumns.ucrAvailableDataFrames)
    End Sub

    Private Sub SetDefaults()
        clsDeleteColumns = New RFunction
        clsDeleteRows = New RFunction
        clsOperatorRowNames = New ROperator
        clsRemoveEmptyColumns = New RFunction
        clsConcFunction = New RFunction
        clsDummyFunction = New RFunction

        ucrSelectorForDeleteColumns.Reset()

        clsDeleteRows.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_rows_in_data")
        clsDeleteColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_columns_in_data")

        clsOperatorRowNames.SetOperation(":")
        clsOperatorRowNames.AddParameter("From", 1, iPosition:=0)
        clsOperatorRowNames.AddParameter("To", 1, iPosition:=1)

        clsDeleteRows.AddParameter("row_names", clsROperatorParameter:=clsOperatorRowNames)

        clsConcFunction.SetRCommand("c")
        clsConcFunction.AddParameter("x", Chr(34) & "cols" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsConcFunction.AddParameter("y", Chr(34) & "rows" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)

        clsRemoveEmptyColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_empty")
        clsRemoveEmptyColumns.AddParameter("which", clsRFunctionParameter:=clsConcFunction, iPosition:=0)

        clsDummyFunction.AddParameter("checked", "columns", iPosition:=0)

        ucrBase.clsRsyntax.SetBaseRFunction(clsDeleteColumns)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorForDeleteColumns.AddAdditionalCodeParameterPair(clsDeleteColumns, ucrSelectorForDeleteColumns.GetParameter, iAdditionalPairNo:=1)
        ucrPnlColumnsOrRows.SetRCode(clsDummyFunction, bReset)
        ucrReceiverForColumnsToDelete.SetRCode(clsDeleteColumns)
        ucrSelectorForDeleteColumns.SetRCode(clsDeleteRows)
        ucrNudTo.SetRCode(clsOperatorRowNames, bReset)
        ucrNudFrom.SetRCode(clsOperatorRowNames, bReset)
        ucrChkEmptyColumns.SetRCode(clsConcFunction, bReset)
        ucrChkEmptyRows.SetRCode(clsConcFunction, bReset)
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
        ElseIf rdoEmpty.Checked Then
            If ucrChkEmptyColumns.Checked OrElse ucrChkEmptyRows.Checked Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ReopenDialog()
        'temp fix to receiver containing deleted column on reopen
        ucrReceiverForColumnsToDelete.Clear()
        SetMaxMin()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlColumnsOrRows_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlColumnsOrRows.ControlValueChanged
        If rdoColumns.Checked Then
            clsDummyFunction.AddParameter("checked", "columns", iPosition:=0)
            ucrBase.clsRsyntax.SetBaseRFunction(clsDeleteColumns)
            ucrSelectorForDeleteColumns.SetVariablesVisible(True)
        ElseIf rdoRows.Checked Then
            clsDummyFunction.AddParameter("checked", "rows", iPosition:=0)
            ucrBase.clsRsyntax.SetBaseRFunction(clsDeleteRows)
            ucrSelectorForDeleteColumns.SetVariablesVisible(False)
        ElseIf rdoEmpty.Checked Then
            clsDummyFunction.AddParameter("checked", "empty", iPosition:=0)
            ucrBase.clsRsyntax.SetBaseRFunction(clsRemoveEmptyColumns)
            ucrSelectorForDeleteColumns.SetVariablesVisible(False)
        End If
    End Sub

    Private Sub ucrSelectorForDeleteColumns_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForDeleteColumns.ControlValueChanged
        SetMaxMin()
        clsRemoveEmptyColumns.AddParameter("data_name", Chr(34) & ucrSelectorForDeleteColumns.strCurrentDataFrame & Chr(34), iPosition:=0)
    End Sub

    Private Sub SetMaxMin()
        Dim iLength As Integer

        If ucrSelectorForDeleteColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ' Should use ucrSelectorForDeleteColumns.ucrAvailableDataFrames.iDataFrameLength but doesn't update before dialog loads
            iLength = frmMain.clsRLink.GetDataFrameLength(ucrSelectorForDeleteColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            ucrNudFrom.SetMinMax(1, iLength)
            ucrNudTo.SetMinMax(1, iLength)
        End If
    End Sub

    Private Sub ucrChkEmptyColumns_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkEmptyColumns.ControlValueChanged, ucrChkEmptyRows.ControlValueChanged
        If ucrChkEmptyRows.Checked Then
            clsConcFunction.AddParameter("y", Chr(34) & "rows" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        Else
            clsConcFunction.RemoveParameterByName("y")
        End If
        If ucrChkEmptyColumns.Checked Then
            clsConcFunction.AddParameter("x", Chr(34) & "cols" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        Else
            clsConcFunction.RemoveParameterByName("x")
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverForColumnsToDelete.ControlContentsChanged,
    ucrNudFrom.ControlContentsChanged, ucrPnlColumnsOrRows.ControlContentsChanged, ucrNudTo.ControlContentsChanged,
    ucrChkEmptyColumns.ControlContentsChanged, ucrChkEmptyRows.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class