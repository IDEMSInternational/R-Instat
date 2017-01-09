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
Public Class dlgInfill
    Private bFirstLoad As Boolean = True
    Private Sub dlgInfill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$infill_missing_dates")
        ucrReceiverDate.Selector = ucrInfillSelector
        ucrReceiverFactors.Selector = ucrInfillSelector
        ucrReceiverFactors.SetIncludedDataTypes({"factor"})
        'ucrBase.iHelpTopicID
    End Sub

    Private Sub SetDefaults()
        ucrInfillSelector.Reset()
        ucrReceiverDate.SetMeAsReceiver()
        TestOkEnabled()
    End Sub
    Private Sub TestOkEnabled()
        If ucrReceiverDate.IsEmpty Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrInfillSelector_DataFrameChanged() Handles ucrInfillSelector.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrInfillSelector.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub ucrReceiverDate_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverDate.SelectionChanged
        If Not ucrReceiverDate.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("date_name", ucrReceiverDate.GetVariableNames())
        Else
            ucrBase.clsRsyntax.RemoveParameter("date_name")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverFactors_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverFactors.SelectionChanged
        If Not ucrReceiverDate.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("factors", ucrReceiverFactors.GetVariableNames())
        Else
            ucrBase.clsRsyntax.RemoveParameter("factors")
        End If
    End Sub
End Class