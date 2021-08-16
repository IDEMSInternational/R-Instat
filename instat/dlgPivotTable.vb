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
Public Class dlgPivotTable
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsRPivotTable As New RFunction

    Private Sub dlgBoxPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.clsRsyntax.iCallType = 2

        ucrSelectorPivot.SetParameter(New RParameter("data", iNewPosition:=0))
        ucrSelectorPivot.SetParameterIsrfunction()

        ucrReceiverInitialRowFactor.SetParameter(New RParameter("rows", iNewPosition:=1))
        ucrReceiverInitialRowFactor.SetParameterIsString()

        ucrReceiverInitialColumnFactor.SetParameter(New RParameter("cols", iNewPosition:=2))
        ucrReceiverInitialColumnFactor.SetParameterIsString()

        ucrChkSelectedVariable.SetText("Selected Variable")
        ucrChkSelectedVariable.AddToLinkedControls(ucrReceiverSelectedVariable, {"TRUE"}, bNewLinkedHideIfParameterMissing:=True)
        ttSelectedVariable.SetToolTip(ucrChkSelectedVariable.chkCheck, "Include the dataframe if unchecked")

        ucrChkIncludeSubTotals.SetText("Include Sub Totals")
        ucrChkIncludeSubTotals.SetParameter(New RParameter("subtotals", iNewPosition:=3))
        ucrChkIncludeSubTotals.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkIncludeSubTotals.SetRDefault("FALSE")
    End Sub


    Private Sub SetDefaults()
        clsRPivotTable = New RFunction

        ucrReceiverInitialRowFactor.SetMeAsReceiver()

        clsRPivotTable.SetRCommand("rpivotTable")

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorPivot.SetRCode(clsRPivotTable, bReset)
        ucrReceiverInitialColumnFactor.SetRCode(clsRPivotTable, bReset)
        ucrReceiverInitialRowFactor.SetRCode(clsRPivotTable, bReset)
    End Sub

    Private Sub TestOkEnabled()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrChkSelectedVariable_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSelectedVariable.ControlValueChanged
        If ucrChkSelectedVariable.Checked Then
            ucrReceiverSelectedVariable.SetMeAsReceiver()
        End If
    End Sub
End Class