
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
Public Class dlgRugPlot
    Private clsDefaultFunction As New RFunction
    Private clsRgeom_RugPlotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgRugPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
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
        ucrSaveGraph.SetRCode(clsDefaultFunction, bReset)
        ucrRugPlotSelector.SetRCode(clsDefaultFunction, bReset)

        ucrReceiverX.SetRCode(clsRaesFunction, bReset)
        ucrFactorOptionalReceiver.SetRCode(clsRaesFunction, bReset)
        ucrVariablesAsFactorForRugPlot.SetRCode(clsRaesFunction, bReset)

    End Sub

    Private Sub TestOkEnabled()
        ''tests when okay Is enable
        'If (ucrReceiverX.IsEmpty() AndAlso ucrVariablesAsFactorForRugPlot.IsEmpty) OrElse Not ucrSaveGraph.IsComplete Then
        '    ucrBase.OKEnabled(False)
        'Else
        '    ucrBase.OKEnabled(True)
        'End If
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 476
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        ucrRugPlotSelector.SetParameter(New RParameter("data", 0))

        ucrVariablesAsFactorForRugPlot.SetFactorReceiver(ucrFactorOptionalReceiver)
        ucrVariablesAsFactorForRugPlot.SetSelector(ucrRugPlotSelector)
        ucrVariablesAsFactorForRugPlot.SetIncludedDataType({"factor", "numeric"})
        ucrVariablesAsFactorForRugPlot.SetParameter(New RParameter("y"))

        ucrReceiverX.Selector = ucrRugPlotSelector
        ucrReceiverX.SetIncludedDataTypes({"factor", "numeric"})
        ucrReceiverX.SetParameter(New RParameter("x"))


        ucrFactorOptionalReceiver.Selector = ucrRugPlotSelector
        ucrFactorOptionalReceiver.SetIncludedDataTypes({"factor", "numeric"})
        ucrFactorOptionalReceiver.SetParameter(New RParameter("colour"))

        ucrSaveGraph.SetPrefix("Rug")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetCheckBoxText("Save graph")
        ucrSaveGraph.SetDataFrameSelector(ucrRugPlotSelector.ucrAvailableDataFrames)
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub
    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction
        clsRaesFunction = New RFunction
        clsRgeom_RugPlotFunction = New RFunction

        ucrRugPlotSelector.Reset()
        ucrSaveGraph.Reset()
        ucrVariablesAsFactorForRugPlot.ResetControl()

        ucrBase.clsRsyntax.SetOperation("+")
        clsDefaultFunction.SetRCommand("ggplot")
        clsRaesFunction.SetRCommand("aes")
        clsDefaultFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsDefaultFunction)


        ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_RugPlotFunction)
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetDataFrame(strNewDataFrame:=ucrRugPlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        sdgPlots.ShowDialog()
    End Sub
    Private Sub cmdRugPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdRugPlotOptions.Click


        ''''''' i wonder if all this will be needed for the new system

        'sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRDefaultggplotFunction, clsTempGeomFunc:=clsRgeom_RugPlotFunction, clsTempAesFunc:=clsRaesFunction, bFixAes:=True, bFixGeom:=True, strDataframe:=ucrRugPlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bApplyAesGlobally:=True, bIgnoreGlobalAes:=False)
        'sdgLayerOptions.ShowDialog()

        'For Each clsParam In clsRaesFunction.clsParameters
        '    If clsParam.strArgumentName = "y" AndAlso (clsParam.strArgumentValue <> "value" OrElse ucrVariablesAsFactorForRugPlot.bSingleVariable) Then
        '        ucrVariablesAsFactorForRugPlot.Add(clsParam.strArgumentValue)
        '    ElseIf clsParam.strArgumentName = "x" Then
        '        ucrReceiverX.Add(clsParam.strArgumentValue)
        '    ElseIf clsParam.strArgumentName = "colour" Then
        '        ucrFactorOptionalReceiver.Add(clsParam.strArgumentValue)
        '    End If
        'Next
    End Sub

End Class