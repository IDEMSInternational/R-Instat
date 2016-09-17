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
Public Class dlgRowStats
    Public bFirstLoad As Boolean = True
    Private Sub dlgRowStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub SetDefaults()
        ucrSelectorForRowStats.Reset()
        ucrSelectorForRowStats.Focus()
        ucrInputcboRowSummary.SetPrefix("RowSummary")
        rdoMean.Checked = True
    End Sub

    Private Sub ReopenDialog()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverForRowStatistics.IsEmpty AndAlso Not ucrInputcboRowSummary.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    'this is only temporary and needs to be worked on later
    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction("apply")
        ucrReceiverForRowStatistics.Selector = ucrSelectorForRowStats
        ucrReceiverForRowStatistics.bUseFilteredData = False
        ucrReceiverForRowStatistics.SetMeAsReceiver()
        ucrReceiverForRowStatistics.SetDataType("numeric")
        ucrBase.clsRsyntax.AddParameter("MARGIN", 1)

        ucrInputcboRowSummary.SetPrefix("RowSummary")
        ucrInputcboRowSummary.SetItemsTypeAsColumns()
        ucrInputcboRowSummary.SetDefaultTypeAsColumn()
        ucrInputcboRowSummary.SetDataFrameSelector(ucrSelectorForRowStats.ucrAvailableDataFrames)

        ucrBase.iHelpTopicID = 45
        cmdUserDefined.Enabled = False
        ucrInputcboRowSummary.SetValidationTypeAsRVariable()
    End Sub


    Private Sub ucrReceiverForRowStatistics_SelectionChanged() Handles ucrReceiverForRowStatistics.SelectionChanged
        If Not ucrReceiverForRowStatistics.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("X", clsRFunctionParameter:=ucrReceiverForRowStatistics.GetVariables(True))
        Else
            ucrBase.clsRsyntax.RemoveParameter("x")
        End If
        TestOKEnabled()
    End Sub

    Private Sub Statistic_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMean.CheckedChanged, rdoCount.CheckedChanged, rdoMaximum.CheckedChanged, rdoMinimum.CheckedChanged, rdoSum.CheckedChanged, rdoStandardDeviation.CheckedChanged, rdoNumberofMissing.CheckedChanged, rdoMedian.CheckedChanged, rdoMedian.CheckedChanged, rdoNumberofMissing.CheckedChanged
        If rdoMean.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("FUN", "mean")
        ElseIf rdoCount.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("FUN", "function(z) sum(!is.na(z))")
        ElseIf rdoMaximum.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("FUN", "max")
        ElseIf rdoMinimum.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("FUN", "min")
        ElseIf rdoSum.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("FUN", "sum")
        ElseIf rdoStandardDeviation.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("FUN", "sd")
        ElseIf rdoMedian.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("FUN", "median")
        ElseIf rdoNumberofMissing.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("FUN", "function(z) sum(is.na(z))")
        Else
            ucrBase.clsRsyntax.RemoveParameter("FUN")
        End If

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrInputcboRowSummary_NameChanged() Handles ucrInputcboRowSummary.NameChanged
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrInputcboRowSummary.GetText, strTempDataframe:=ucrSelectorForRowStats.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrInputcboRowSummary.GetText)
        TestOKEnabled()
    End Sub
End Class