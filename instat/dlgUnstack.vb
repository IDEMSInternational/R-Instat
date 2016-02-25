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

Public Class dlgUnstack
    Public bFirstLoad As Boolean = True
    Private Sub dlgUnstack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrFactorToUnstackReceiver.Selector = ucrSelectorForUnstack
        ucrColumnToUnstackReceiver.Selector = ucrSelectorForUnstack
        ucrBase.clsRsyntax.SetFunction("tidyr::spread")
        ucrBase.clsRsyntax.iCallType = 2
        autoTranslate(Me)
        ucrBase.iHelpTopicID = 58

        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        'Checks if Ok can be enabled.
        TestOKEnabled()
    End Sub

    Private Sub SetDefaults()
        ucrFactorToUnstackReceiver.SetMeAsReceiver()
        ucrSelectorForUnstack.Reset()
        chkKeepUnusedFactorLevels.Checked = False
    End Sub

    Private Sub ReopenDialog()


    End Sub

    Private Sub TestOKEnabled()
        If ucrFactorToUnstackReceiver.IsEmpty() = False And ucrColumnToUnstackReceiver.IsEmpty() = False Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrSelectorForUnstack_DataFrameChanged() Handles ucrSelectorForUnstack.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data", clsRFunctionParameter:=ucrSelectorForUnstack.ucrAvailableDataFrames.clsCurrDataFrame)

    End Sub

    Private Sub ucrFactorToUnstackReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrFactorToUnstackReceiver.SelectionChanged
        ucrBase.clsRsyntax.AddParameter("key", ucrFactorToUnstackReceiver.GetVariableNames(False))
        TestOKEnabled()
    End Sub


    Private Sub ucrColumnToUnstackReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrColumnToUnstackReceiver.SelectionChanged
        ucrBase.clsRsyntax.AddParameter("value", ucrColumnToUnstackReceiver.GetVariableNames(False))
        TestOKEnabled()
    End Sub

    Private Sub chkKeepUnusedFactorLevels_CheckedChanged(sender As Object, e As EventArgs) Handles chkKeepUnusedFactorLevels.CheckedChanged

        If chkKeepUnusedFactorLevels.Checked = False Then
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                ucrBase.clsRsyntax.AddParameter("drop", "TRUE")
            Else
                ucrBase.clsRsyntax.RemoveParameter("drop")
            End If
        Else
            ucrBase.clsRsyntax.AddParameter("drop", "FALSE")
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

End Class

