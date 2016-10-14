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
Public Class dlgTablePlus
    Public bFirstLoad As Boolean = True
    Private Sub dlgTablePlus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        If ((Not ucrReceiverExpressionForTablePlus.IsEmpty) OrElse (Not ucrInputProbabilities.IsEmpty)) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If

    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverExpressionForTablePlus.SetIncludedDataTypes({"numeric"})
        ucrInputNewColNameforTablePlus.SetItemsTypeAsColumns()
        ucrInputNewColNameforTablePlus.SetDefaultTypeAsColumn()
        ucrInputNewColNameforTablePlus.SetDataFrameSelector(ucrSelectorForDataFrame.ucrAvailableDataFrames)
        ucrInputNewColNameforTablePlus.SetValidationTypeAsRVariable()

    End Sub

    Private Sub SetDefaults()
        rdoQuantiles.Checked = True
        chkGraphResults.Checked = True
        chkSIngleValues.Checked = True
        ReceiverLabels()
        SaveResults()
        ucrInputProbabilities.SetName("0.5")
        If rdoProbabilities.Checked Then
            ucrInputNewColNameforTablePlus.SetPrefix("prob")
            ucrInputNewColNameforTablePlus.SetName("prob")
        Else
            ucrInputNewColNameforTablePlus.SetPrefix("Quant")
            ucrInputNewColNameforTablePlus.SetName("Quant")
        End If
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

    Private Sub pqParameters()
        If rdoProbabilities.Checked Then
            If chkSaveResults.Checked Then
                ucrBase.clsRsyntax.AddParameter("q", clsRFunctionParameter:=ucrReceiverExpressionForTablePlus.GetVariables)
            Else
                ucrBase.clsRsyntax.AddParameter("q", ucrInputProbabilities.GetText)
            End If
        Else
            If chkSaveResults.Checked Then
                ucrBase.clsRsyntax.AddParameter("p", clsRFunctionParameter:=ucrReceiverExpressionForTablePlus.GetVariables)
            Else
                ucrBase.clsRsyntax.AddParameter("p", ucrInputProbabilities.GetText)
            End If
        End If

    End Sub

    Private Sub SaveResults()
        If chkSaveResults.Checked Then
            ucrInputNewColNameforTablePlus.Visible = True
            ucrBase.clsRsyntax.SetAssignTo(ucrInputNewColNameforTablePlus.GetText(), strTempColumn:=ucrInputNewColNameforTablePlus.GetText(), strTempDataframe:=ucrSelectorForDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bAssignToIsPrefix:=True)
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = True
            ucrBase.clsRsyntax.iCallType = 0
        Else
            ucrBase.clsRsyntax.RemoveAssignTo()
            ucrBase.clsRsyntax.iCallType = 2
            ucrInputNewColNameforTablePlus.Visible = False
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        End If
    End Sub
    Private Sub DisplayGraphResults()
        If chkGraphResults.Checked Then
            ucrBase.clsRsyntax.AddParameter("plot", "TRUE")
            ucrBase.clsRsyntax.iCallType = 0
        Else
            ucrBase.clsRsyntax.AddParameter("plot", "FALSE")
        End If
    End Sub
    Private Sub rdoProbabilitiesandQuantiles_CheckedChanged(sender As Object, e As EventArgs) Handles rdoProbabilities.CheckedChanged, rdoQuantiles.CheckedChanged
        ReceiverLabels()
    End Sub

    Private Sub ReceiverLabels()
        ucrBase.clsRsyntax.ClearParameters()
        pqParameters()
        ucrBase.clsRsyntax.AddParameter("dist", Chr(34) & ucrDistributionsFOrTablePlus.clsCurrDistribution.strRName & Chr(34))
        If rdoProbabilities.Checked Then
            lblQuantValues.Visible = True
            lblProbValues.Visible = False
            ucrBase.clsRsyntax.SetFunction("mosaic::pdist")

        Else
            lblQuantValues.Visible = False
            lblProbValues.Visible = True
            ucrBase.clsRsyntax.SetFunction("mosaic::qdist")
        End If

        For Each clstempparam In ucrDistributionsFOrTablePlus.clsCurrRFunction.clsParameters
            ucrBase.clsRsyntax.AddParameter(clstempparam.Clone())
        Next
    End Sub

    Private Sub ucrReceiverExpressionForTablePlus_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverExpressionForTablePlus.SelectionChanged
        ReceiverLabels()
        TestOKEnabled()
    End Sub

    Private Sub ucrInputProbabilities_NameChanged(ender As Object, e As EventArgs) Handles ucrInputProbabilities.TextChanged
        ReceiverLabels()
        TestOKEnabled()
    End Sub

    Private Sub ucrDistributionsFOrTablePlus_ParameterChanged() Handles ucrDistributionsFOrTablePlus.ParameterChanged
        ReceiverLabels()
    End Sub

    Private Sub chkSIngleValues_CheckedChanged(sender As Object, e As EventArgs) Handles chkSIngleValues.CheckedChanged
        results()
    End Sub

    Private Sub results()
        If chkSIngleValues.Checked Then
            chkSaveResults.Enabled = False
            chkSaveResults.Checked = False
            ucrInputNewColNameforTablePlus.Enabled = False
            ucrReceiverExpressionForTablePlus.Visible = False
            ucrInputProbabilities.Visible = True
            ucrSelectorForDataFrame.Reset()
            ucrSelectorForDataFrame.Reset()
            ucrInputProbabilities.SetName("0.5")
        Else
            chkSaveResults.Enabled = True
            ucrReceiverExpressionForTablePlus.Selector = ucrSelectorForDataFrame
            ucrReceiverExpressionForTablePlus.SetMeAsReceiver()
            ucrReceiverExpressionForTablePlus.Visible = False
            ucrInputNewColNameforTablePlus.Enabled = True
            ucrInputProbabilities.Visible = False
            ucrInputProbabilities.Reset()
            ucrReceiverExpressionForTablePlus.Visible = True

        End If
    End Sub
End Class
