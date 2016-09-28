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
Public Class dlgTablesPlus
    Public bFirstLoad As Boolean = True
    Private Sub dlgTablesPlus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverExpressionForTablePlus.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If

    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverExpressionForTablePlus.SetIncludedDataTypes({"numeric"})
        ucrInputNewColName.SetItemsTypeAsColumns()
        ucrInputNewColName.SetDefaultTypeAsColumn()
        ucrInputNewColName.SetDataFrameSelector(ucrSelectorForDataFrame.ucrAvailableDataFrames)
        ucrInputNewColName.SetValidationTypeAsRVariable()
    End Sub

    Private Sub SetDefaults()
        rdoQuantiles.Checked = True
        chkGraphResults.Checked = True
        ReceiverLabels()
        SaveResults()
        ucrSelectorForDataFrame.Reset()
        ucrReceiverExpressionForTablePlus.SetDefaultValue("0.5")
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub chkGraphResults_CheckedChanged(sender As Object, e As EventArgs) Handles chkGraphResults.CheckedChanged, chkSaveResults.CheckedChanged
        DisplayGraphResults()
        SaveResults()
        TestOKEnabled()
    End Sub

    Private Sub SaveResults()
        If chkSaveResults.Checked Then
            ucrReceiverExpressionForTablePlus.Selector = ucrSelectorForDataFrame
            ucrReceiverExpressionForTablePlus.SetMeAsReceiver()
            ucrInputNewColName.Visible = True
            ucrReceiverExpressionForTablePlus.SetDefaultValue("")
        Else
            ucrInputNewColName.Visible = False
            ucrReceiverExpressionForTablePlus.SetDefaultValue("0.5")
        End If
    End Sub
    Private Sub DisplayGraphResults()
        If chkGraphResults.Checked Then
            ucrBase.clsRsyntax.iCallType = 0
        Else
        End If
    End Sub
    Private Sub rdoProbabilitiesandQuantiles_CheckedChanged(sender As Object, e As EventArgs) Handles rdoProbabilities.CheckedChanged, rdoQuantiles.CheckedChanged
        ReceiverLabels()
    End Sub

    Private Sub ReceiverLabels()
        If rdoProbabilities.Checked Then
            lblValues.Visible = True
            lblProbabilities.Visible = False
            ucrInputNewColName.SetName("prob")
        Else
            lblValues.Visible = False
            lblProbabilities.Visible = True
            ucrInputNewColName.SetName("Quant")
        End If
    End Sub

    Private Sub ucrInputNewColName_NameChanged() Handles ucrInputNewColName.NameChanged

    End Sub
End Class