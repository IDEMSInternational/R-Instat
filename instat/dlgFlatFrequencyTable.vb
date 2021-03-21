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
Public Class dlgFlatFrequencyTable
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsFTable, clsTable, clsAddMargin As New RFunction
    Private Sub dlgFlatFrequencyTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 2

        ucrRowVariable.SetParameter(New RParameter("row.vars", 0))
        ucrRowVariable.SetParameterIsString()
        ucrRowVariable.bExcludeFromSelector = True
        ucrRowVariable.Selector = ucrSelectorDataFrame

        ucrColumnVariable.SetParameter(New RParameter("col.vars", 1))
        ucrColumnVariable.SetParameterIsString()
        ucrColumnVariable.Selector = ucrSelectorDataFrame
        ucrColumnVariable.SetDataType("factor")
        ucrColumnVariable.bExcludeFromSelector = True

        ucrChkAddMargins.AddParameterValueFunctionNamesCondition(True, "x", "addmargins", True)
        ucrChkAddMargins.AddParameterValueFunctionNamesCondition(False, "x", "addmargins", False)
        ucrChkAddMargins.SetText("Add Margins")
    End Sub

    Private Sub SetDefaults()
        clsFTable = New RFunction
        clsTable = New RFunction
        clsAddMargin = New RFunction

        ucrColumnVariable.SetMeAsReceiver()
        ucrSelectorDataFrame.Reset()

        clsTable.SetRCommand("table")

        clsAddMargin.SetPackageName("stats")
        clsAddMargin.SetRCommand("addmargins")
        clsAddMargin.AddParameter(clsRFunctionParameter:=clsTable)

        clsFTable.SetPackageName("stats")
        clsFTable.SetRCommand("ftable")
        clsFTable.AddParameter("x", clsRFunctionParameter:=clsTable)
        ucrBase.clsRsyntax.SetBaseRFunction(clsFTable)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrChkAddMargins.SetRCode(clsAddMargin, bReset)
        ucrRowVariable.SetRCode(clsFTable, bReset)
        ucrColumnVariable.SetRCode(clsFTable, bReset)
        ucrSelectorDataFrame.SetRCode(clsTable, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrSelectorDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            If (ucrRowVariable.lstSelectedVariables.Items.Count + ucrColumnVariable.lstSelectedVariables.Items.Count > 1) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrChkAddMargins_ControlValueChanged(ucrchangedcontrol As ucrCore) Handles ucrChkAddMargins.ControlValueChanged
        If ucrChkAddMargins.Checked Then
            clsFTable.AddParameter("x", clsRFunctionParameter:=clsAddMargin)
        Else
            clsFTable.AddParameter("x", clsRFunctionParameter:=clsTable)
        End If
    End Sub

    Private Sub ucrRowReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrRowVariable.ControlValueChanged, ucrColumnVariable.ControlValueChanged, ucrSelectorDataFrame.ControlValueChanged
        Dim clsGetVar As New RFunction
        clsGetVar.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsGetVar.AddParameter("data_name", Chr(34) & ucrSelectorDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        clsTable.AddParameter("x", clsRFunctionParameter:=clsGetVar)
        If Not ucrRowVariable.IsEmpty AndAlso Not ucrColumnVariable.IsEmpty Then
            clsGetVar.AddParameter("col_names", "c(" & ucrColumnVariable.GetVariableNames & "," & ucrRowVariable.GetVariableNames & ")")
        ElseIf Not ucrRowVariable.IsEmpty AndAlso ucrColumnVariable.IsEmpty Then
            clsGetVar.AddParameter("col_names", (ucrRowVariable.GetVariableNames))
        ElseIf ucrRowVariable.IsEmpty AndAlso Not ucrColumnVariable.IsEmpty Then
            clsGetVar.AddParameter("col_names", (ucrColumnVariable.GetVariableNames))
        End If
    End Sub

    Private Sub ucrRowReceiver_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrRowVariable.ControlContentsChanged, ucrColumnVariable.ControlContentsChanged, ucrSelectorDataFrame.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class