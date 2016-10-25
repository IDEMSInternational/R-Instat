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
    Public clsRClimdexInput As New RFunction
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
    'Public Sub SetOperator()
    '    Dim clsTempRFunc As New RFunction
    '    If chkHorizontalBoxplot.Checked Then
    '        clsTempRFunc.SetRCommand("coord_flip")
    '        ucrBase.clsRsyntax.AddOperatorParameter("coord_flip", clsRFunc:=clsTempRFunc)
    '    Else
    '        ucrBase.clsRsyntax.RemoveOperatorParameter("coord_flip")
    '    End If
    'End Sub

    Private Sub SetDefaults()
        ' ucrSaveClimdex.chkSaveClimdex.Checked = True

        'clsRaesFunction.ClearParameters()
        'clsRgeom_boxplotFunction.ClearParameters()
        'ucrSelectorBoxPlot.Reset()
        'ucrSelectorBoxPlot.Focus()
        'ucrVariablesAsFactorForBoxplot.ResetControl()
        'chkHorizontalBoxplot.Checked = False
        'sdgPlots.Reset()

        'SetXParameter()
        clsRClimdexInput.AddParameter("tmax.dates", "as.PCICt(do.call(paste, ec.1018935.tmax[,c(" & Chr(34) & "year" & Chr(34) & "," & Chr(34) & "jday" & Chr(34) & ")]), format=" & Chr(34) & "%Y %j" & Chr(34) & ", cal=" & Chr(34) & "gregorian" & Chr(34) & ")")
        clsRClimdexInput.AddParameter("tmin.dates", "as.PCICt(do.call(paste, ec.1018935.tmin[,c(" & Chr(34) & "year" & Chr(34) & "," & Chr(34) & "jday" & Chr(34) & ")]), format=" & Chr(34) & "%Y %j" & Chr(34) & ", cal=" & Chr(34) & "gregorian" & Chr(34) & ")")
        clsRClimdexInput.AddParameter("prec.dates", "as.PCICt(do.call(paste, ec.1018935.prec[,c(" & Chr(34) & "year" & Chr(34) & "," & Chr(34) & "jday" & Chr(34) & ")]), format=" & Chr(34) & "%Y %j" & Chr(34) & ", cal=" & Chr(34) & "gregorian" & Chr(34) & ")")
        sdgClimdexIndices.SetDefaults()
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        clsRClimdexInput.SetRCommand("climdexInput.raw")
        'clsRggplotFunction.SetRCommand("ggplot")
        'clsRgeom_boxplotFunction.SetRCommand("geom_boxplot")
        'clsRaesFunction.SetRCommand("aes")
        'clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        'ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)
        'ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_boxplotFunction)


        'ucrBase.iHelpTopicID = 436

        ucrBaseClimdex.clsRsyntax.iCallType = 2

        ucrReceiverTmax.Selector = ucrSelectorClimdex
        ucrReceiverTmin.Selector = ucrSelectorClimdex
        ucrReceiverPrec.Selector = ucrSelectorClimdex
        ''ucrByFactorsReceiver.SetIncludedDataTypes({"factor"})

        ''ucrSecondFactorReceiver.Selector = ucrSelectorBoxPlot
        ''ucrSecondFactorReceiver.SetIncludedDataTypes({"factor"})



        'sdgLayerOptions.SetRSyntax(ucrBase.clsRsyntax)
        'sdgPlots.SetRSyntax(ucrBase.clsRsyntax)
        'sdgPlots.SetGgplotFunction(clsRggplotFunction)

        ''ucrVariablesAsFactorForBoxplot.SetFactorReceiver(ucrByFactorsReceiver)
        ''ucrVariablesAsFactorForBoxplot.SetSelector(ucrSelectorBoxPlot)
        ''ucrVariablesAsFactorForBoxplot.SetIncludedDataType({"numeric"})


        ''ucrSaveBoxplot.SetDataFrameSelector(ucrSelectorBoxPlot.ucrAvailableDataFrames)
        'ucrSaveClimdex.strPrefix = "Climdex"
        'ucrBaseClimdex.clsRsyntax.bExcludeAssignedFunctionOutput = False
    End Sub

    Private Sub TestOkEnabled()

        If ucrReceiverTmax.IsEmpty AndAlso ucrReceiverTmin.IsEmpty AndAlso ucrReceiverPrec.IsEmpty Then
            ucrBaseClimdex.OKEnabled(False)
        Else
            ucrBaseClimdex.OKEnabled(True)
        End If
    End Sub

    'Private Sub IndicesChanged(sender As Object, e As EventArgs) Handles sdgClimdexIndices. rdoTwoColumns.CheckedChanged, rdoMultipleColumns.CheckedChanged

    'End Sub
    'Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
    '    sdgPlots.SetDataFrame(strNewDataFrame:=ucrSelectorBoxPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
    '    sdgPlots.ShowDialog()
    'End Sub

    'Private Sub ucrSelectorBoxPlot_DataFrameChanged() Handles ucrSelectorBoxPlot.DataFrameChanged
    '    clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorBoxPlot.ucrAvailableDataFrames.clsCurrDataFrame)
    'End Sub

    'Private Sub ucrByFactorsReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrByFactorsReceiver.SelectionChanged
    '    SetXParameter()
    'End Sub

    'Private Sub SetXParameter()
    '    If Not ucrByFactorsReceiver.IsEmpty Then
    '        clsRaesFunction.AddParameter("x", ucrByFactorsReceiver.GetVariableNames(False))
    '    Else
    '        clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))
    '    End If
    'End Sub

    'Private Sub ucrSecondFactorReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrSecondFactorReceiver.SelectionChanged

    '    If Not ucrSecondFactorReceiver.IsEmpty Then
    '        clsRaesFunction.AddParameter("fill", ucrSecondFactorReceiver.GetVariableNames(False))
    '    Else
    '        clsRaesFunction.RemoveParameterByName("fill")
    '    End If
    'End Sub

    Private Sub ReopenDialog()
    End Sub

    'Private Sub cmdBoxPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdBoxPlotOptions.Click
    '    sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=clsRgeom_boxplotFunction, clsTempAesFunc:=clsRaesFunction, bFixAes:=True, bFixGeom:=True, strDataframe:=ucrSelectorBoxPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bUseGlobalAes:=True)
    '    sdgLayerOptions.ShowDialog()
    '    For Each clsParam In clsRaesFunction.clsParameters
    '        If clsParam.strArgumentName = "x" Then
    '            If clsParam.strArgumentValue = "" Then
    '                ucrByFactorsReceiver.Clear()
    '            Else
    '                ucrByFactorsReceiver.Add(clsParam.strArgumentValue)
    '            End If
    '        ElseIf clsParam.strArgumentName = "y" Then
    '            ucrVariablesAsFactorForBoxplot.Add(clsParam.strArgumentValue)
    '        ElseIf clsParam.strArgumentName = "fill" Then
    '            ucrSecondFactorReceiver.Add(clsParam.strArgumentValue)
    '        End If
    '    Next
    'End Sub

    Private Sub ucrBaseClimdex_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseClimdex.ClickReset
        SetDefaults()
    End Sub

    'Private Sub chkHorizontalBoxplot_CheckedChanged(sender As Object, e As EventArgs) Handles chkHorizontalBoxplot.CheckedChanged
    '    SetOperator()
    'End Sub

    'Private Sub UcrVariablesAsFactor1_SelectionChanged() Handles ucrVariablesAsFactorForBoxplot.SelectionChanged
    '    If Not ucrVariablesAsFactorForBoxplot.IsEmpty Then
    '        clsRaesFunction.AddParameter("y", ucrVariablesAsFactorForBoxplot.GetVariableNames(False))
    '    Else
    '        clsRaesFunction.RemoveParameterByName("y")
    '    End If
    '    TestOkEnabled()
    'End Sub

    'Private Sub ucrSaveClimdex_ClimdexNameChanged() Handles ucrSaveClimdex.ClimdexNameChanged, ucrSaveClimdex.SaveClimdexCheckedChanged
    '    If ucrSaveClimdex.bSaveClimdex Then
    '        ucrBaseClimdex.clsRsyntax.SetAssignTo(ucrSaveClimdex.strClimdexName, strTempDataframe:=ucrSelectorClimdex.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempClimdex:=ucrSaveClimdex.strClimdexName)
    '    Else
    '        ucrBaseClimdex.clsRsyntax.RemoveAssignTo()
    '    End If
    '    'TestOkEnabled()
    'End Sub

    'Private Sub ucrReceivers_SelectionChang(sender As Object, e As EventArgs) Handles ucrReceiverTmax.SelectionChanged, ucrReceiverTmin.SelectionChanged, ucrReceiverPrec.SelectionChanged
    '    ucrBaseClimdex.clsRsyntax.AddParameter("tmax", clsRFunctionParameter:=ucrReceiverTmax.GetVariables())
    '    ucrBaseClimdex.clsRsyntax.AddParameter("tmin", clsRFunctionParameter:=ucrReceiverTmin.GetVariables())
    '    ucrBaseClimdex.clsRsyntax.AddParameter("prec", clsRFunctionParameter:=ucrReceiverPrec.GetVariables())
    '    TestOkEnabled()
    'End Sub

    Private Sub ucrReceiverTmax_Leave(sender As Object, e As EventArgs) Handles ucrReceiverTmax.Leave
        clsRClimdexInput.AddParameter("tmax", clsRFunctionParameter:=ucrReceiverTmax.GetVariables())
        TestOkEnabled()
    End Sub
    Private Sub ucrReceiverTmin_Leave(sender As Object, e As EventArgs) Handles ucrReceiverTmin.Leave
        clsRClimdexInput.AddParameter("tmin", clsRFunctionParameter:=ucrReceiverTmin.GetVariables())
        TestOkEnabled()
    End Sub
    Private Sub ucrReceiverPrec_Leave(sender As Object, e As EventArgs) Handles ucrReceiverPrec.Leave
        clsRClimdexInput.AddParameter("prec", clsRFunctionParameter:=ucrReceiverPrec.GetVariables())
        TestOkEnabled()
    End Sub

    Private Sub cmdClimdexIndices_Click(sender As Object, e As EventArgs) Handles cmdClimdexIndices.Click
        sdgClimdexIndices.ShowDialog()
    End Sub

    'Private Sub ucrBaseClimdex_clickok(sender As Object, e As EventArgs) Handles ucrBaseClimdex.ClickOk
    '    sdgClimdexIndices.IndicesOptions()
    'End Sub
End Class