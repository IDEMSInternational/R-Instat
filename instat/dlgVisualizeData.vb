' R- Instat
' Copyright (C) 2015-2017
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
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations

Public Class dlgVisualizeData
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsVisDatFunction, clsVisMissFunction, clsVisGuessFunction As New RFunction
    Private Sub dlgVisualizeData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 3

        ucrPnlVisualizeData.AddRadioButton(rdoVisDat)
        ucrPnlVisualizeData.AddRadioButton(rdoVisMiss)
        ucrPnlVisualizeData.AddRadioButton(rdoVisGuess)

        ucrPnlVisualizeData.AddFunctionNamesCondition(rdoVisDat, "vis_dat")
        ucrPnlVisualizeData.AddFunctionNamesCondition(rdoVisDat, "vis_miss")
        ucrPnlVisualizeData.AddFunctionNamesCondition(rdoVisDat, "vis_guess")

        ucrPnlSelectData.AddRadioButton(rdoWholeDataFrame)
        ucrPnlSelectData.AddRadioButton(rdoSelectedColumn)

        ucrPnlSelectData.AddParameterPresentCondition(rdoWholeDataFrame, "data")
        ucrPnlSelectData.AddParameterPresentCondition(rdoSelectedColumn, "x")

        ucrSelectorVisualizeData.SetParameter(New RParameter("data", 0, False))
        ucrSelectorVisualizeData.SetParameterIsrfunction()

        ucrReceiverVisualizeData.SetParameter(New RParameter("x", 0))
        ucrReceiverVisualizeData.SetParameterIsRFunction()
        ucrReceiverVisualizeData.Selector = ucrSelectorVisualizeData
        ucrReceiverVisualizeData.SetMeAsReceiver()

        ucrPnlSelectData.AddToLinkedControls(ucrReceiverVisualizeData, {rdoSelectedColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrSaveGraph.SetPrefix("graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorVisualizeData.ucrAvailableDataFrames)
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub
    Private Sub SetDefaults()
        clsVisDatFunction = New RFunction
        clsVisMissFunction = New RFunction
        clsVisGuessFunction = New RFunction

        ucrSelectorVisualizeData.Reset()

        clsVisDatFunction.SetPackageName("visdat")
        clsVisDatFunction.SetRCommand("vis_dat")
        clsVisDatFunction.AddParameter("sort_type", "TRUE", iPosition:=1)
        clsVisDatFunction.AddParameter("palette", Chr(34) & "default" & Chr(34), iPosition:=2)
        clsVisDatFunction.AddParameter("warn_large_data", "TRUE", iPosition:=3)
        clsVisDatFunction.AddParameter("large_data_size", 900000, iPosition:=4)

        clsVisMissFunction.SetPackageName("visdat")
        clsVisMissFunction.SetRCommand("vis_miss")
        clsVisMissFunction.AddParameter("cluster", "TRUE", iPosition:=1)
        clsVisMissFunction.AddParameter("sort_miss", "FALSE", iPosition:=2)
        clsVisMissFunction.AddParameter("show_perc", "TRUE", iPosition:=3)
        clsVisMissFunction.AddParameter("show_perc_col", "TRUE", iPosition:=4)
        clsVisMissFunction.AddParameter("large_data_size", 900000, iPosition:=5)
        clsVisMissFunction.AddParameter("warn_large_data", "TRUE", iPosition:=6)

        clsVisGuessFunction.SetPackageName("visdat")
        clsVisGuessFunction.SetRCommand("vis_guess")
        clsVisGuessFunction.AddParameter("palette", Chr(34) & "default" & Chr(34), iPosition:=1)

        ucrBase.clsRsyntax.SetBaseRFunction(clsVisDatFunction)
    End Sub
    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorVisualizeData.AddAdditionalCodeParameterPair(clsVisMissFunction, New RParameter("data", 0, False), 1)
        ucrSelectorVisualizeData.AddAdditionalCodeParameterPair(clsVisGuessFunction, New RParameter("data", 0, False), 2)
        ucrReceiverVisualizeData.AddAdditionalCodeParameterPair(clsVisMissFunction, New RParameter("x", 0), 1)
        ucrReceiverVisualizeData.AddAdditionalCodeParameterPair(clsVisGuessFunction, New RParameter("x", 0), 2)
        ucrSaveGraph.AddAdditionalRCode(clsVisMissFunction, 1)
        ucrSaveGraph.AddAdditionalRCode(clsVisGuessFunction, 2)

        ucrReceiverVisualizeData.SetRCode(clsVisDatFunction, bReset)
        ucrSaveGraph.SetRCode(clsVisDatFunction, bReset)
        ucrSelectorVisualizeData.SetRCode(clsVisDatFunction, bReset)
    End Sub
    Private Sub TestOkEnabled()
        If rdoWholeDataFrame.Checked AndAlso ucrSelectorVisualizeData.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrBase.OKEnabled(True)
        ElseIf rdoSelectedColumn.Checked AndAlso Not ucrReceiverVisualizeData.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub
    Private Sub ucrCore_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverVisualizeData.ControlContentsChanged, ucrSelectorVisualizeData.ControlContentsChanged, ucrPnlSelectData.ControlContentsChanged
        TestOkEnabled()
    End Sub
    Private Sub ucrPnlVisualizeData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlVisualizeData.ControlContentsChanged
        If rdoVisDat.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsVisDatFunction)
        ElseIf rdoVisMiss.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsVisMissFunction)
        ElseIf rdoVisGuess.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsVisGuessFunction)
        End If
    End Sub
End Class