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

Public Class dlgPlot
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_lineplotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        Else
            'reopendialog
        End If
        If bReset Then
            SetDefaults()
        End If

        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrLinePlotSelector.SetRCode(clsRggplotFunction, bReset)
        ucrReceiverX.SetRCode(clsRaesFunction, bReset)
        ucrVariablesAsFactorForLinePlot.SetRCode(clsRaesFunction, bReset)
        ucrFactorOptionalReceiver.SetRCode(clsRaesFunction, bReset)
        ucrSave.SetRCode(clsBaseOperator, bReset)
        ucrChkPoints.SetRCode(clsBaseOperator, bReset)
    End Sub

    Private Sub InitialiseDialog()

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.iHelpTopicID = 434

        ucrLinePlotSelector.SetParameter(New RParameter("data"))
        ucrLinePlotSelector.SetParameterIsrfunction()

        ucrReceiverX.Selector = ucrLinePlotSelector
        ucrReceiverX.SetIncludedDataTypes({"numeric", "factor"})
        ucrReceiverX.SetParameter(New RParameter("x"))
        ucrReceiverX.bWithQuotes = False
        ucrReceiverX.SetParameterIsString()
        ucrReceiverX.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrReceiverX.bAddParameterIfEmpty = True

        ucrFactorOptionalReceiver.Selector = ucrLinePlotSelector
        ucrFactorOptionalReceiver.SetIncludedDataTypes({"factor"})
        ucrFactorOptionalReceiver.SetParameter(New RParameter("colour"))
        ucrFactorOptionalReceiver.bWithQuotes = False
        ucrFactorOptionalReceiver.SetParameterIsString()

        ucrVariablesAsFactorForLinePlot.SetFactorReceiver(ucrFactorOptionalReceiver)
        ucrVariablesAsFactorForLinePlot.Selector = ucrLinePlotSelector
        ucrVariablesAsFactorForLinePlot.SetIncludedDataTypes({"numeric", "factor"})
        ucrVariablesAsFactorForLinePlot.SetParameter(New RParameter("y"))
        ucrVariablesAsFactorForLinePlot.SetParameterIsString()
        ucrVariablesAsFactorForLinePlot.bWithQuotes = False
        ucrVariablesAsFactorForLinePlot.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrVariablesAsFactorForLinePlot.bAddParameterIfEmpty = True

        ucrChkPoints.SetText("Points")



        ucrSave.SetPrefix("Line")
        ucrSave.SetIsComboBox()
        ucrSave.SetSaveTypeAsGraph()
        ucrSave.SetCheckBoxText("Save Graph")
        ucrSave.SetDataFrameSelector(ucrLinePlotSelector.ucrAvailableDataFrames)
        ucrSave.SetAssignToIfUncheckedValue("last_graph")

        sdgPlots.SetRSyntax(ucrBase.clsRsyntax)

    End Sub
    Private Sub SetDefaults()

        clsRggplotFunction = New RFunction
        clsRgeom_lineplotFunction = New RFunction
        clsRaesFunction = New RFunction
        clsBaseOperator = New ROperator

        ucrLinePlotSelector.Reset()
        ucrSave.Reset()
        ucrVariablesAsFactorForLinePlot.SetMeAsReceiver()
        sdgPlots.Reset()

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("lineplot", clsRFunctionParameter:=clsRgeom_lineplotFunction)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")
        clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))
        clsRaesFunction.AddParameter("y", Chr(34) & Chr(34))

        clsRgeom_lineplotFunction.SetRCommand("geom_line")
        clsRgeom_lineplotFunction.SetPackageName("ggplot2")

        clsBaseOperator.RemoveParameterByName("geom_point")
        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrLinePlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        TempOptionsDisabledInMultipleVariablesCase()
        TestOkEnabled()
    End Sub

    Private Sub TestOkEnabled()
        'Both x and y aesthetics are mandatory for geom_line. However, when not filled they will be automatically populated by "".
        If Not ucrSave.IsComplete OrElse (ucrReceiverX.IsEmpty AndAlso ucrVariablesAsFactorForLinePlot.IsEmpty) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub
    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetDataFrame(strNewDataFrame:=ucrLinePlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        sdgPlots.ShowDialog()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
    End Sub

    Private Sub ucrChkPoints_CheckedChanged() Handles ucrChkPoints.ControlValueChanged
        Dim clsTempRFunc As New RFunction
        If ucrChkPoints.Checked = True Then
            clsTempRFunc.SetRCommand("geom_point")
            clsTempRFunc.SetPackageName("ggplot2")
            clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsTempRFunc)
        Else
            clsBaseOperator.RemoveParameterByName("geom_point")
        End If
    End Sub

    Private Sub UcrVariablesAsFactor_ControlValueChanged() Handles ucrVariablesAsFactorForLinePlot.ControlValueChanged
        TempOptionsDisabledInMultipleVariablesCase()
    End Sub

    Private Sub TempOptionsDisabledInMultipleVariablesCase()
        ' Why is this done??
        If ucrVariablesAsFactorForLinePlot.bSingleVariable Then
            cmdLineOptions.Enabled = True
            cmdOptions.Enabled = True
        Else
            cmdLineOptions.Enabled = False
            cmdOptions.Enabled = False
        End If
    End Sub

    Private Sub cmdLineOptions_Click(sender As Object, e As EventArgs) Handles cmdLineOptions.Click
        sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=clsRgeom_lineplotFunction, clsTempAesFunc:=clsRaesFunction, bFixAes:=True, bFixGeom:=True, strDataframe:=ucrLinePlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bApplyAesGlobally:=True, bIgnoreGlobalAes:=False)
        sdgLayerOptions.ShowDialog()
        'Coming from the sdgLayerOptions, clsRaesFunction and others has been modified. One then needs to display these modifications on the dlgScatteredPlot.

        'The aesthetics parameters on the main dialog are repopulated as required. 
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                If clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                    ucrReceiverX.Clear()
                Else
                    ucrReceiverX.Add(clsParam.strArgumentValue)
                End If
                'In the y case, the vlue stored in the clsReasFunction in the multiplevariables case is "value", however that one shouldn't be written in the multiple variables receiver (otherwise it would stack all variables and the stack ("value") itself!).
                'Warning: what if someone used the name value for one of it's variables independently from the multiple variables method ? Here if the receiver is actually in single mode, the variable "value" will still be given back, which throws the problem back to the creation of "value" in the multiple receiver case.
            ElseIf clsParam.strArgumentName = "y" AndAlso (clsParam.strArgumentValue <> "value" OrElse ucrVariablesAsFactorForLinePlot.bSingleVariable) Then
                'Still might be in the case of bSingleVariable with mapping y="".
                If clsParam.strArgumentValue = (Chr(34) & Chr(34)) Then
                    ucrVariablesAsFactorForLinePlot.Clear()
                Else ucrVariablesAsFactorForLinePlot.Add(clsParam.strArgumentValue)
                End If
            ElseIf clsParam.strArgumentName = "colour" Then
                ucrFactorOptionalReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
        TestOkEnabled()
    End Sub

    Private Sub AllControl_ControlContentsChanged() Handles ucrReceiverX.ControlContentsChanged, ucrVariablesAsFactorForLinePlot.ControlContentsChanged, ucrSave.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class