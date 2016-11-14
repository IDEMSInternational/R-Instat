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
Public Class dlgChiSquareTest
    Public bFirstLoad As Boolean = True
    Private Sub ChiSquareTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverChiSquare.Selector = ucrAddRemove
        ucrReceiverChiSquare.SetMeAsReceiver()
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.SetFunction("chisq.test")
        autoTranslate(Me)
        cboLayoutOfData.Text = "Multiple Data Columns"
        ucrBase.iHelpTopicID = 175
        ucrReceiverChiSquare.SetSingleTypeStatus(True)
    End Sub

    Private Sub SetDefaults()
        chkContinuityCorrection.Checked = True
        chkSaveValues.Enabled = False ' temporarily
    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrReceiverChiSquare_Leave(sender As Object, e As EventArgs) Handles ucrReceiverChiSquare.Leave
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverChiSquare.GetVariables())
    End Sub

    Private Sub chkContinuityCorrection_CheckedChanged(sender As Object, e As EventArgs) Handles chkContinuityCorrection.CheckedChanged
        If chkContinuityCorrection.Checked Then
            ucrBase.clsRsyntax.AddParameter("correct", "TRUE")
        Else
            ucrBase.clsRsyntax.AddParameter("correct", "FALSE")
        End If
    End Sub

End Class