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

Imports instat.Translations
Public Class dlgFlatFrequencyTable
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsFtable, clsTable, clsAddMargin As New RFunction
    Private Sub dlgFlatFrequencyTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        Else

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

        ucrRowVariable.SetParameter(New RParameter("row.vars", 1))
        ucrRowVariable.SetParameterIsString()
        ucrRowVariable.bExcludeFromSelector = True
        ucrRowVariable.Selector = ucrSelectorDataFrame

        ucrColumnVariable.SetParameter(New RParameter("col.vars", 2))
        ucrColumnVariable.SetParameterIsString()
        ucrColumnVariable.Selector = ucrSelectorDataFrame
        ucrColumnVariable.SetDataType("factor")
        ucrColumnVariable.bExcludeFromSelector = True

        ucrChkAddMargins.AddParameterValueFunctionNamesCondition(True, "x", "addmargins", True)
        ucrChkAddMargins.AddParameterValueFunctionNamesCondition(False, "x", "addmargins", False)
        ucrChkAddMargins.SetText("Add Margins")
    End Sub

    Private Sub SetDefaults()
        clsFtable = New RFunction
        clsTable = New RFunction
        clsAddMargin = New RFunction

        ucrRowVariable.SetMeAsReceiver()
        ucrSelectorDataFrame.Reset()

        clsTable.SetRCommand("table")
        clsAddMargin.SetRCommand("addmargins")
        clsAddMargin.AddParameter(clsRFunctionParameter:=clsTable)
        clsFtable.SetRCommand("ftable")
        clsFtable.AddParameter("table", clsRFunctionParameter:=clsTable)
        ucrBase.clsRsyntax.SetBaseRFunction(clsFtable)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrChkAddMargins.SetRCode(clsAddMargin, bReset)
        ucrRowVariable.SetRCode(clsFtable, bReset)
        ucrColumnVariable.SetRCode(clsFtable, bReset)
        ucrSelectorDataFrame.SetRCode(clsTable, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrRowVariable.IsEmpty AndAlso Not ucrColumnVariable.IsEmpty AndAlso ucrSelectorDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
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

    Private Sub ucrChkAddMargins_ControlValueChanged(ucrchangedcontrol As ucrCore) Handles ucrChkAddMargins.ControlValueChanged
        If ucrChkAddMargins.Checked Then
            clsFtable.RemoveParameterByName("table")
            clsFtable.AddParameter("x", clsRFunctionParameter:=clsAddMargin)
        Else
            clsFtable.RemoveParameterByName("x")
            clsFtable.AddParameter("table", clsRFunctionParameter:=clsTable)
        End If
    End Sub

    Private Sub ucrRowReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrRowVariable.ControlValueChanged, ucrColumnVariable.ControlValueChanged, ucrSelectorDataFrame.ControlValueChanged
        Dim clsGetVar As New RFunction
        If Not ucrRowVariable.IsEmpty AndAlso Not ucrColumnVariable.IsEmpty Then
            clsGetVar.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
            clsGetVar.AddParameter("data_name", Chr(34) & ucrSelectorDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
            clsGetVar.AddParameter("col_names", "c(" & ucrColumnVariable.GetVariableNames & "," & ucrRowVariable.GetVariableNames & ")")
            clsTable.AddParameter("y", clsRFunctionParameter:=clsGetVar)
        End If
    End Sub

    Private Sub ucrRowReceiver_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrRowVariable.ControlContentsChanged, ucrColumnVariable.ControlContentsChanged, ucrSelectorDataFrame.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class