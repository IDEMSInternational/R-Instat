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
Imports instat
Imports instat.Translations
Public Class dlgClimdex
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Public clsDefaultFunction As New RFunction
    'Public clsRClimdexInput As New RFunction
    Public clsRDataName, clsRTmax, clsRTmin, clsRPrec, clsRDate, clsRPCIct, clsRChar As New RFunction

    Private Sub dlgClimdex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        ReopenDialog()
        TestOkEnabled()
    End Sub

    Private Sub SetDefaults()
        ucrSelectorClimdex.Reset()
        ucrSelectorClimdex.Focus()
        ucrReceiverDate.SetMeAsReceiver()
        'sdgClimdexIndices.InitialiseControls()


        'chkNHemisphere.Checked = True
        'nudYearFrom.Value = 1961
        'nudYearTo.Value = 1990
        'nudN.Value = 5
        'nudAnnualMissingDays.Value = 15
        'nudMothlyMissingDays.Value = 3
        'nudMinBaseData.Value = 0.1
        'ucrInputFreq.cboInput.SelectedItem = "annual"
        'ucrMultipleInputPrecQtiles.txtNumericItems.Text = "0.95, 0.99"
        'ucrMultipleInputTempQtiles.txtNumericItems.Text = "0.1, 0.9"
        'TestOkEnabled()

        'Dim clsDefaultFunction As New RFunction

        'ucrSelectorOneVarGraph.Reset()
        'ucrSaveGraph.Reset()

        'Define the default RFunction
        clsDefaultFunction.SetRCommand("climdexInput.raw")
        clsRTmax.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsRTmin.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsRPrec.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsRDate.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsRPCIct.SetRCommand("as.PCICt")
        clsRChar.SetRCommand("as.character")
        clsRPCIct.AddParameter("cal", Chr(34) & "gregorian" & Chr(34))


        clsRChar.AddParameter("x", clsRFunctionParameter:=clsRDate)
        clsRPCIct.AddParameter("x", clsRFunctionParameter:=clsRChar)
        clsDefaultFunction.SetAssignTo("climdex_input")

        ' Set default RFunction as the base function
        ucrBaseClimdex.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        'add rfunction as parameters of the main function here
        ucrBaseClimdex.clsRsyntax.AddParameter("tmax", clsRFunctionParameter:=clsRTmax)
        ucrBaseClimdex.clsRsyntax.AddParameter("tmax.dates", clsRFunctionParameter:=clsRPCIct)
        ucrBaseClimdex.clsRsyntax.AddParameter("tmin", clsRFunctionParameter:=clsRTmin)
        ucrBaseClimdex.clsRsyntax.AddParameter("tmin.dates", clsRFunctionParameter:=clsRPCIct)
        ucrBaseClimdex.clsRsyntax.AddParameter("prec", clsRFunctionParameter:=clsRPrec)
        ucrBaseClimdex.clsRsyntax.AddParameter("prec.dates", clsRFunctionParameter:=clsRPCIct)
        bResetSubdialog = True
        'TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBaseClimdex.iHelpTopicID = 190
        ucrBaseClimdex.clsRsyntax.iCallType = 0

        ucrSelectorClimdex.SetParameter(New RParameter("data_name", 0))
        ucrSelectorClimdex.SetParameterIsString()

        ucrReceiverDate.Selector = ucrSelectorClimdex
        ucrReceiverDate.SetDataType("Date")
        'ucrReceiverDate.SetMeAsReceiver()
        ucrReceiverDate.SetParameter(New RParameter("col_name"))
        ucrReceiverDate.SetParameterIsString()

        ucrReceiverTmax.Selector = ucrSelectorClimdex
        ucrReceiverTmax.SetParameter(New RParameter("col_name"))
        ucrReceiverTmax.SetParameterIsString()

        ucrReceiverTmin.Selector = ucrSelectorClimdex
        ucrReceiverTmin.SetParameter(New RParameter("col_name"))
        ucrReceiverTmin.SetParameterIsString()

        ucrReceiverPrec.Selector = ucrSelectorClimdex
        ucrReceiverPrec.SetParameter(New RParameter("col_name"))
        ucrReceiverPrec.SetParameterIsString()


        'clsRClimdexInput.SetRCommand("climdexInput.raw")
        'ucrBaseClimdex.clsRsyntax.SetBaseRFunction(clsRClimdexInput)


        'ucrMultipleInputTempQtiles.bIsNumericInput = True
        'ucrMultipleInputPrecQtiles.bIsNumericInput = True

        'ucrReceiverTmax.Selector = ucrSelectorClimdex
        'ucrReceiverTmin.Selector = ucrSelectorClimdex
        'ucrReceiverPrec.Selector = ucrSelectorClimdex
        'ucrInputFreq.SetItems({"monthly", "annual"})
        AssignName()
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverDate.IsEmpty AndAlso (Not ucrReceiverTmax.IsEmpty OrElse Not ucrReceiverTmin.IsEmpty OrElse Not ucrReceiverPrec.IsEmpty) Then
            AddRemoveDates()
            ucrBaseClimdex.OKEnabled(True)
        Else
            ucrBaseClimdex.OKEnabled(False)
        End If
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        'SetRCode(Me, ucrBaseClimdex.clsRsyntax.clsBaseFunction, bReset)
        ucrSelectorClimdex.SetRCode(clsRDate, bReset)
        ucrSelectorClimdex.SetRCode(clsRTmax, bReset)
        ucrSelectorClimdex.SetRCode(clsRTmin, bReset)
        ucrSelectorClimdex.SetRCode(clsRPrec, bReset)
        ucrReceiverDate.SetRCode(clsRDate, bReset)
        ucrReceiverTmax.SetRCode(clsRTmax, bReset)
        ucrReceiverTmin.SetRCode(clsRTmin, bReset)
        ucrReceiverPrec.SetRCode(clsRPrec, bReset)
    End Sub

    Private Sub ucrBaseClimdex_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseClimdex.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    'Private Sub ucrSelectorClimdex_DataFrameChanged() Handles ucrSelectorClimdex.DataFrameChanged
    '    clsRDate.AddParameter("data_name", Chr(34) & ucrSelectorClimdex.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    '    AssignName()
    'End Sub

    'Private Sub ucrReceiverDate_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverDate.SelectionChanged
    '    clsRDate.AddParameter("col_name", ucrReceiverDate.GetVariableNames())
    '    clsRChar.AddParameter("x", clsRFunctionParameter:=clsRDate)
    '    clsRPCIct.AddParameter("x", clsRFunctionParameter:=clsRChar)
    '    TestOkEnabled()
    'End Sub

    Private Sub AddRemoveDates()
        If Not ucrReceiverTmax.IsEmpty Then
            ucrBaseClimdex.clsRsyntax.AddParameter("tmax", clsRFunctionParameter:=clsRTmax)
            ucrBaseClimdex.clsRsyntax.AddParameter("tmax.dates", clsRFunctionParameter:=clsRPCIct)
        Else
            ucrBaseClimdex.clsRsyntax.RemoveParameter("tmax.dates")
            ucrBaseClimdex.clsRsyntax.RemoveParameter("tmax")
        End If
        If Not ucrReceiverTmin.IsEmpty Then
            ucrBaseClimdex.clsRsyntax.AddParameter("tmin", clsRFunctionParameter:=clsRTmin)
            ucrBaseClimdex.clsRsyntax.AddParameter("tmin.dates", clsRFunctionParameter:=clsRPCIct)

        Else
            ucrBaseClimdex.clsRsyntax.RemoveParameter("tmin")
            ucrBaseClimdex.clsRsyntax.RemoveParameter("tmin.dates")
        End If
        If Not ucrReceiverPrec.IsEmpty Then
            ucrBaseClimdex.clsRsyntax.AddParameter("prec", clsRFunctionParameter:=clsRPrec)
            ucrBaseClimdex.clsRsyntax.AddParameter("prec.dates", clsRFunctionParameter:=clsRPCIct)
        Else
            ucrBaseClimdex.clsRsyntax.RemoveParameter("prec")
            ucrBaseClimdex.clsRsyntax.RemoveParameter("prec.dates")
        End If
    End Sub

    'Private Sub AddDataFrameParameter()
    'clsRDate.AddParameter("data_name", Chr(34) & ucrSelectorClimdex.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    'clsRTmax.AddParameter("data_name", Chr(34) & ucrSelectorClimdex.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    'clsRTmin.AddParameter("data_name", Chr(34) & ucrSelectorClimdex.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    'clsRPrec.AddParameter("data_name", Chr(34) & ucrSelectorClimdex.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    'End Sub


    'Private Sub ucrReceiverTmax_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverTmax.SelectionChanged
    '    clsRTmax.AddParameter("data_name", Chr(34) & ucrSelectorClimdex.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))

    '    If Not ucrReceiverTmax.IsEmpty Then
    '        clsRTmax.AddParameter("col_name", ucrReceiverTmax.GetVariableNames())
    '        clsDefaultFunction.AddParameter("tmax", clsRFunctionParameter:=clsRTmax)
    '        clsDefaultFunction.AddParameter("tmax.dates", clsRFunctionParameter:=clsRPCIct)
    '    Else
    '        clsDefaultFunction.RemoveParameterByName("tmax")
    '        clsDefaultFunction.RemoveParameterByName("tmax.dates")
    '    End If
    '    TestOkEnabled()
    'End Sub

    'Private Sub ucrReceiverTmin_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverTmin.SelectionChanged
    '    clsRTmin.AddParameter("data_name", Chr(34) & ucrSelectorClimdex.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    '    If Not ucrReceiverTmin.IsEmpty Then
    '        clsRTmin.AddParameter("col_name", ucrReceiverTmin.GetVariableNames())
    '        clsDefaultFunction.AddParameter("tmin", clsRFunctionParameter:=clsRTmin)
    '        clsDefaultFunction.AddParameter("tmin.dates", clsRFunctionParameter:=clsRPCIct)
    '    Else
    '        clsDefaultFunction.RemoveParameterByName("tmin")
    '        clsDefaultFunction.RemoveParameterByName("tmin.dates")
    '    End If
    '    TestOkEnabled()
    'End Sub

    'Private Sub ucrReceiverPrec_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverPrec.SelectionChanged
    '    clsRPrec.AddParameter("data_name", Chr(34) & ucrSelectorClimdex.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    '    If Not ucrReceiverPrec.IsEmpty Then
    '        clsRPrec.AddParameter("col_name", ucrReceiverPrec.GetVariableNames())
    '        clsDefaultFunction.AddParameter("prec", clsRFunctionParameter:=clsRPrec)
    '        clsDefaultFunction.AddParameter("prec.dates", clsRFunctionParameter:=clsRPCIct)
    '    Else
    '        clsDefaultFunction.RemoveParameterByName("prec")
    '        clsDefaultFunction.RemoveParameterByName("prec.dates")
    '    End If
    '    TestOkEnabled()
    'End Sub

    Private Sub cmdIndices_Click(sender As Object, e As EventArgs) Handles cmdIndices.Click
        sdgClimdexIndices.SetRFunction(ucrBaseClimdex.clsRsyntax.clsBaseFunction, bResetSubdialog)
        bResetSubdialog = False
        sdgClimdexIndices.ShowDialog()
    End Sub

    Private Sub ucrBaseClimdex_clickok(sender As Object, e As EventArgs) Handles ucrBaseClimdex.ClickOk
        sdgClimdexIndices.IndicesOptions()
    End Sub

    'Private Sub nudYearFromTo_ValueChanged(sender As Object, e As EventArgs) Handles nudYearFrom.ValueChanged, nudYearTo.ValueChanged
    '    clsRClimdexInput.AddParameter("base.range", "c(" & nudYearFrom.Value & "," & nudYearTo.Value & ")")
    '    If nudYearFrom.Value = 1961 AndAlso nudYearTo.Value = 1990 Then
    '        clsRClimdexInput.RemoveParameterByName("base.range")
    '    End If
    'End Sub

    'Private Sub nudN_ValueChanged(sender As Object, e As EventArgs) Handles nudN.ValueChanged
    '    clsRClimdexInput.AddParameter("n", nudN.Value)
    '    If nudN.Value = 5 Then
    '        clsRClimdexInput.RemoveParameterByName("n")
    '    End If
    'End Sub

    'Private Sub chkNHemisphere_CheckedChanged(sender As Object, e As EventArgs) Handles chkNHemisphere.CheckedChanged
    '    If chkNHemisphere.Checked Then
    '        clsRClimdexInput.RemoveParameterByName("northern.hemisphere")
    '    Else
    '        clsRClimdexInput.AddParameter("northern.hemisphere", "FALSE")
    '    End If
    'End Sub

    'Private Sub nudAnnualMaxMissingDays_ValueChanged(sender As Object, e As EventArgs) Handles nudAnnualMissingDays.ValueChanged
    '    clsRMaxMisingDays.AddParameter("annual", nudAnnualMissingDays.Value)
    '    If nudAnnualMissingDays.Value = 15 AndAlso nudMothlyMissingDays.Value = 3 Then
    '        clsRClimdexInput.RemoveParameterByName("max.missing.days")
    '    Else
    '        clsRClimdexInput.AddParameter("max.missing.days", clsRFunctionParameter:=clsRMaxMisingDays)
    '    End If
    'End Sub

    'Private Sub nudMonthlyMaxMissingDays_ValueChanged(sender As Object, e As EventArgs) Handles nudMothlyMissingDays.ValueChanged
    '    clsRMaxMisingDays.AddParameter("monthly", nudMothlyMissingDays.Value)
    '    If nudAnnualMissingDays.Value = 15 AndAlso nudMothlyMissingDays.Value = 3 Then
    '        clsRClimdexInput.RemoveParameterByName("max.missing.days")
    '    Else
    '        clsRClimdexInput.AddParameter("max.missing.days", clsRFunctionParameter:=clsRMaxMisingDays)
    '    End If
    'End Sub

    'Private Sub ucrInputFreq_Load(sender As Object, e As EventArgs)

    'End Sub

    'Private Sub nudMinBaseData_ValueChanged(sender As Object, e As EventArgs) Handles nudMinBaseData.ValueChanged
    '    clsRClimdexInput.AddParameter("min.base.data.fraction.present ", nudMinBaseData.Value)
    '    If nudMinBaseData.Value = 0.1 Then
    '        clsRClimdexInput.RemoveParameterByName("min.base.data.fraction.present ")
    '    End If
    'End Sub

    'Private Sub ucrMultipleInputPrecQtiles_Leave(sender As Object, e As EventArgs) Handles ucrMultipleInputPrecQtiles.Leave
    '    If ucrMultipleInputPrecQtiles.txtNumericItems.Text <> "0.95, 0.99" Then
    '        clsRClimdexInput.AddParameter("prec.qtiles", ucrMultipleInputPrecQtiles.clsNumericList.ToScript)
    '    Else
    '        clsRClimdexInput.RemoveParameterByName("prec.qtiles")
    '    End If
    'End Sub

    'Private Sub ucrMultipleInputTempQtiles_Leave(sender As Object, e As EventArgs) Handles ucrMultipleInputTempQtiles.Leave
    '    If ucrMultipleInputTempQtiles.txtNumericItems.Text <> "0.1, 0.9" Then
    '        clsRClimdexInput.AddParameter("temp.qtiles", ucrMultipleInputTempQtiles.clsNumericList.ToScript)
    '    Else
    '        clsRClimdexInput.RemoveParameterByName("temp.qtiles")
    '    End If
    'End Sub

    'Private Sub ucrInputFreq_Leave(sender As Object, e As EventArgs) Handles ucrInputFreq.Leave
    '    Select Case ucrInputFreq.GetText
    '        Case "annual"
    '            sdgClimdexIndices.clsRTwoArg1.AddParameter("freq", Chr(34) & "annual" & Chr(34))
    '            sdgClimdexIndices.clsRThreeArg.AddParameter("freq", Chr(34) & "annual" & Chr(34))
    '        Case "monthly"
    '            sdgClimdexIndices.clsRTwoArg1.AddParameter("freq", Chr(34) & "monthly" & Chr(34))
    '            sdgClimdexIndices.clsRThreeArg.AddParameter("freq", Chr(34) & "monthly" & Chr(34))
    '    End Select
    'End Sub

    Private Sub AssignName()
        ucrBaseClimdex.clsRsyntax.SetAssignTo("climdex_input")
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorClimdex.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrReceiverPrec.ControlContentsChanged, ucrReceiverTmax.ControlContentsChanged, ucrReceiverTmin.ControlContentsChanged
        'AddDataFrameParameter()
        TestOkEnabled()
    End Sub
End Class