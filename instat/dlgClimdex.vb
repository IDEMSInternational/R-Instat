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
Public Class dlgClimdex
    Public clsRClimdexInput, clsRMaxMisingDays, clsRTmax, clsRTmin, clsRPrec As New RFunction
    Private bFirstLoad As Boolean = True

    Private Sub dlgClimdex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
    End Sub

    Private Sub SetDefaults()
        ucrSelectorClimdex.Reset()
        ucrSelectorClimdex.Focus()
        ucrReceiverTmax.SetMeAsReceiver()
        sdgClimdexIndices.SetDefaults()
        chkNHemisphere.Checked = True
        nudYearFrom.Value = 1961
        nudYearTo.Value = 1990
        nudN.Value = 5
        nudAnnualMissingDays.Value = 15
        nudMothlyMissingDays.Value = 3
        nudMinBaseData.Value = 0.1
        ucrInputFreq.cboInput.SelectedItem = "annual"
        ucrMultipleInputPrecQtiles.txtNumericItems.Text = "0.95, 0.99"
        ucrMultipleInputTempQtiles.txtNumericItems.Text = "0.1, 0.9"
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        clsRClimdexInput.SetRCommand("climdexInput.raw")
        clsRMaxMisingDays.SetRCommand("c")
        clsRTmax.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsRTmin.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsRPrec.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        ucrMultipleInputTempQtiles.bIsNumericInput = True
        ucrMultipleInputPrecQtiles.bIsNumericInput = True
        'ucrBase.iHelpTopicID = 436
        'ucrBaseClimdex.clsRsyntax.iCallType = 0
        ucrReceiverTmax.Selector = ucrSelectorClimdex
        ucrReceiverTmin.Selector = ucrSelectorClimdex
        ucrReceiverPrec.Selector = ucrSelectorClimdex
        ucrInputFreq.SetItems({"monthly", "annual"})

    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverTmax.IsEmpty AndAlso ucrReceiverTmin.IsEmpty AndAlso ucrReceiverPrec.IsEmpty Then
            ucrBaseClimdex.OKEnabled(False)
        Else
            ucrBaseClimdex.OKEnabled(True)
        End If
    End Sub

    Private Sub ReopenDialog()
    End Sub

    Private Sub ucrBaseClimdex_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseClimdex.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrReceiverTmax_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverTmax.SelectionChanged
        clsRTmax.AddParameter("data_name", Chr(34) & ucrSelectorClimdex.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        If Not ucrReceiverTmax.IsEmpty Then
            clsRTmax.AddParameter("col_name", ucrReceiverTmax.GetVariableNames())
            clsRClimdexInput.AddParameter("tmax", clsRFunctionParameter:=clsRTmax)
            clsRClimdexInput.AddParameter("tmax.dates", "as.PCICt(do.call(paste, climdex_data[,c(" & Chr(34) & "year" & Chr(34) & "," & Chr(34) & "jday" & Chr(34) & ")]), format=" & Chr(34) & "%Y %j" & Chr(34) & ", cal=" & Chr(34) & "gregorian" & Chr(34) & ")")
        Else
            clsRClimdexInput.RemoveParameterByName("tmax")
            clsRClimdexInput.RemoveParameterByName("tmax.dates")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverTmin_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverTmin.SelectionChanged
        clsRTmin.AddParameter("data_name", Chr(34) & ucrSelectorClimdex.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        If Not ucrReceiverTmin.IsEmpty Then
            clsRTmin.AddParameter("col_name", ucrReceiverTmin.GetVariableNames())
            clsRClimdexInput.AddParameter("tmin", clsRFunctionParameter:=clsRTmin)
            clsRClimdexInput.AddParameter("tmin.dates", "as.PCICt(do.call(paste, climdex_data[,c(" & Chr(34) & "year" & Chr(34) & "," & Chr(34) & "jday" & Chr(34) & ")]), format=" & Chr(34) & "%Y %j" & Chr(34) & ", cal=" & Chr(34) & "gregorian" & Chr(34) & ")")
        Else
            clsRClimdexInput.RemoveParameterByName("tmin")
            clsRClimdexInput.RemoveParameterByName("tmin.dates")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverPrec_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverPrec.SelectionChanged
        clsRPrec.AddParameter("data_name", Chr(34) & ucrSelectorClimdex.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        If Not ucrReceiverPrec.IsEmpty Then
            clsRPrec.AddParameter("col_name", ucrReceiverPrec.GetVariableNames())
            clsRClimdexInput.AddParameter("prec", clsRFunctionParameter:=clsRPrec)
            clsRClimdexInput.AddParameter("prec.dates", "as.PCICt(do.call(paste, climdex_data[,c(" & Chr(34) & "year" & Chr(34) & "," & Chr(34) & "jday" & Chr(34) & ")]), format=" & Chr(34) & "%Y %j" & Chr(34) & ", cal=" & Chr(34) & "gregorian" & Chr(34) & ")")
        Else
            clsRClimdexInput.RemoveParameterByName("prec")
            clsRClimdexInput.RemoveParameterByName("prec.dates")
        End If
        TestOkEnabled()
    End Sub

    Private Sub cmdClimdexIndices_Click(sender As Object, e As EventArgs) Handles cmdClimdexOptions.Click
        sdgClimdexIndices.ShowDialog()
    End Sub

    Private Sub ucrBaseClimdex_clickok(sender As Object, e As EventArgs) Handles ucrBaseClimdex.ClickOk
        sdgClimdexIndices.IndicesOptions()
    End Sub

    Private Sub nudYearFromTo_ValueChanged(sender As Object, e As EventArgs) Handles nudYearFrom.ValueChanged, nudYearTo.ValueChanged
        clsRClimdexInput.AddParameter("base.range", "c(" & nudYearFrom.Value & "," & nudYearTo.Value & ")")
        If nudYearFrom.Value = 1961 AndAlso nudYearTo.Value = 1990 Then
            clsRClimdexInput.RemoveParameterByName("base.range")
        End If
    End Sub

    Private Sub nudN_ValueChanged(sender As Object, e As EventArgs) Handles nudN.ValueChanged
        clsRClimdexInput.AddParameter("n", nudN.Value)
        If nudN.Value = 5 Then
            clsRClimdexInput.RemoveParameterByName("n")
        End If
    End Sub

    Private Sub chkNHemisphere_CheckedChanged(sender As Object, e As EventArgs) Handles chkNHemisphere.CheckedChanged
        If chkNHemisphere.Checked Then
            clsRClimdexInput.RemoveParameterByName("northern.hemisphere")
        Else
            clsRClimdexInput.AddParameter("northern.hemisphere", "FALSE")
        End If
    End Sub

    Private Sub nudAnnualMaxMissingDays_ValueChanged(sender As Object, e As EventArgs) Handles nudAnnualMissingDays.ValueChanged
        clsRMaxMisingDays.AddParameter("annual", nudAnnualMissingDays.Value)
        If nudAnnualMissingDays.Value = 15 AndAlso nudMothlyMissingDays.Value = 3 Then
            clsRClimdexInput.RemoveParameterByName("max.missing.days")
        Else
            clsRClimdexInput.AddParameter("max.missing.days", clsRFunctionParameter:=clsRMaxMisingDays)
        End If
    End Sub

    Private Sub ucrInputFreq_Load(sender As Object, e As EventArgs) Handles ucrInputFreq.Load

    End Sub

    Private Sub nudMonthlyMaxMissingDays_ValueChanged(sender As Object, e As EventArgs) Handles nudMothlyMissingDays.ValueChanged
        clsRMaxMisingDays.AddParameter("monthly", nudMothlyMissingDays.Value)
        If nudAnnualMissingDays.Value = 15 AndAlso nudMothlyMissingDays.Value = 3 Then
            clsRClimdexInput.RemoveParameterByName("max.missing.days")
        Else
            clsRClimdexInput.AddParameter("max.missing.days", clsRFunctionParameter:=clsRMaxMisingDays)
        End If
    End Sub

    Private Sub nudMinBaseData_ValueChanged(sender As Object, e As EventArgs) Handles nudMinBaseData.ValueChanged
        clsRClimdexInput.AddParameter("min.base.data.fraction.present ", nudMinBaseData.Value)
        If nudMinBaseData.Value = 0.1 Then
            clsRClimdexInput.RemoveParameterByName("min.base.data.fraction.present ")
        End If
    End Sub

    Private Sub ucrMultipleInputPrecQtiles_Leave(sender As Object, e As EventArgs) Handles ucrMultipleInputPrecQtiles.Leave
        If ucrMultipleInputPrecQtiles.txtNumericItems.Text <> "0.95, 0.99" Then
            clsRClimdexInput.AddParameter("prec.qtiles", ucrMultipleInputPrecQtiles.clsNumericList.ToScript)
        Else
            clsRClimdexInput.RemoveParameterByName("prec.qtiles")
        End If
    End Sub

    Private Sub ucrMultipleInputTempQtiles_Leave(sender As Object, e As EventArgs) Handles ucrMultipleInputTempQtiles.Leave
        If ucrMultipleInputTempQtiles.txtNumericItems.Text <> "0.1, 0.9" Then
            clsRClimdexInput.AddParameter("temp.qtiles", ucrMultipleInputTempQtiles.clsNumericList.ToScript)
        Else
            clsRClimdexInput.RemoveParameterByName("temp.qtiles")
        End If
    End Sub

    Private Sub ucrInputFreq_Leave(sender As Object, e As EventArgs) Handles ucrInputFreq.Leave
        Select Case ucrInputFreq.GetText
            Case "annual"
                sdgClimdexIndices.clsRTwoArg1.AddParameter("freq", Chr(34) & "annual" & Chr(34))
                sdgClimdexIndices.clsRThreeArg.AddParameter("freq", Chr(34) & "annual" & Chr(34))
            Case "monthly"
                sdgClimdexIndices.clsRTwoArg1.AddParameter("freq", Chr(34) & "monthly" & Chr(34))
                sdgClimdexIndices.clsRThreeArg.AddParameter("freq", Chr(34) & "monthly" & Chr(34))
        End Select
    End Sub
End Class