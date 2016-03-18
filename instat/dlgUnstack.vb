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
    Private Sub dlgunstack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        'Checks if Ok can be enabled.
        TestOKEnabled()
    End Sub
    Private Sub InitialiseDialog()
        ucrFactorTounstackReceiver.Selector = ucrSelectorForunstack
        ucrColumnTounstackReceiver.Selector = ucrSelectorForunstack
        ucrBase.clsRsyntax.SetFunction("tidyr::spread")
        ucrFactorTounstackReceiver.SetMeAsReceiver()
        ucrSelectorForunstack.Reset()
        SetNewDataFrameName(ucrSelectorForunstack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_unstacked")
        ucrBase.iHelpTopicID = 58
        ucrFactorTounstackReceiver.SetDataType("factor")
    End Sub

    Private Sub SetDefaults()
        chkCarryAllColumns.Checked = True
        chkKeepUnusedFactorLevels.Checked = False
        ucrDataFrameForunstack.Reset()
        ucrDataFrameForunstack.Focus()
        ucrCarryAllColumns.Visible = False
    End Sub

    Private Sub ReopenDialog()


    End Sub

    Private Sub TestOKEnabled()
        If ucrFactorTounstackReceiver.IsEmpty() = False And ucrColumnTounstackReceiver.IsEmpty() = False Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrDataFrameForunstack_Leave(sender As Object, e As EventArgs) Handles ucrDataFrameForunstack.Leave
        SetNewDataFrameName(ucrDataFrameForunstack.txtValidation.Text)
    End Sub

    Private Sub SetNewDataFrameName(strNewVal As String)
        If ucrDataFrameForunstack.IsValidRString(strNewVal) Then
            ucrDataFrameForunstack.txtValidation.Text = strNewVal
            ucrBase.clsRsyntax.SetAssignTo(ucrDataFrameForunstack.txtValidation.Text, strTempDataframe:=ucrDataFrameForunstack.txtValidation.Text)
        Else
            ucrDataFrameForunstack.txtValidation.Text = ""
            ucrBase.clsRsyntax.RemoveAssignTo()
        End If
    End Sub
    Private Sub ucrSelectorForunstack_DataFrameChanged() Handles ucrSelectorForunstack.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data", clsRFunctionParameter:=ucrSelectorForunstack.ucrAvailableDataFrames.clsCurrDataFrame)
        If Not ucrDataFrameForunstack.bUserTyped Then
            SetNewDataFrameName(ucrSelectorForunstack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_unstacked")
        End If

    End Sub

    Private Sub ucrFactorTounstackReceiver_SelectionChanged() Handles ucrFactorTounstackReceiver.SelectionChanged
        If Not ucrFactorTounstackReceiver.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("key", ucrFactorTounstackReceiver.GetVariableNames(False))
        Else
            ucrBase.clsRsyntax.RemoveParameter("key")
        End If
        TestOKEnabled()
    End Sub


    Private Sub ucrColumnTounstackReceiver_SelectionChanged() Handles ucrColumnTounstackReceiver.SelectionChanged
        If Not ucrColumnTounstackReceiver.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("value", ucrColumnTounstackReceiver.GetVariableNames(False))
        Else
            ucrBase.clsRsyntax.RemoveParameter("value")
        End If

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

    Private Sub chkCarryAllColumns_CheckedChanged(sender As Object, e As EventArgs) Handles chkCarryAllColumns.CheckedChanged
        If chkCarryAllColumns.Checked = False Then
            ucrCarryAllColumns.Visible = True
        Else
            ucrCarryAllColumns.Visible = False
        End If
    End Sub
End Class

