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
Public Class dlgTaylorDiagram
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsTaylorDiagramFunction As New RFunction
    Private Sub dlgTaylorDiagram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRcodeForControls(bReset)

        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 3

        ucrSelectorTaylorDiagram.SetParameter(New RParameter("mydata", 0))
        ucrSelectorTaylorDiagram.SetParameterIsrfunction()

        ucrReceiverSingleStation.SetParameter(New RParameter("type", 3))
        ucrReceiverSingleStation.Selector = ucrSelectorTaylorDiagram
        ucrReceiverSingleStation.SetParameterIsString()
        ucrReceiverSingleStation.SetClimaticType("station")
        ucrReceiverSingleStation.bAutoFill = True

        ucrReceiverSingleObserved.SetParameter(New RParameter("obs", 0))
        ucrReceiverSingleObserved.Selector = ucrSelectorTaylorDiagram
        ucrReceiverSingleObserved.SetParameterIsString()
        ucrReceiverSingleObserved.SetIncludedDataTypes({"numeric"})

        ucrReceiverSingleEstimate.SetParameter(New RParameter("mod", 1))
        ucrReceiverSingleEstimate.Selector = ucrSelectorTaylorDiagram
        ucrReceiverSingleEstimate.SetParameterIsString()
        ucrReceiverSingleEstimate.SetIncludedDataTypes({"numeric"})

        ucrReceiverMultipleGroup.SetParameter(New RParameter("group", 2))
        ucrReceiverMultipleGroup.Selector = ucrSelectorTaylorDiagram
        ucrReceiverMultipleGroup.SetParameterIsString()
        ucrReceiverMultipleGroup.SetIncludedDataTypes({"factor", "character"})

        ucrChkNormalise.SetParameter(New RParameter("normalise", 3))
        ucrChkNormalise.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkNormalise.SetText("Normalise")
        ucrChkNormalise.SetRDefault("FALSE")

        ucrSavePlot.SetPrefix("taylordiagram")
        ucrSavePlot.SetCheckBoxText("Save Graph")
        ucrSavePlot.SetIsComboBox()
        ucrSavePlot.SetSaveTypeAsGraph()
        ucrSavePlot.SetDataFrameSelector(ucrSelectorTaylorDiagram.ucrAvailableDataFrames)
        ucrSavePlot.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsTaylorDiagramFunction = New RFunction

        ucrSelectorTaylorDiagram.Reset()
        ucrSavePlot.Reset()
        ucrReceiverSingleStation.SetMeAsReceiver()

        clsTaylorDiagramFunction.SetPackageName("openair")
        clsTaylorDiagramFunction.SetRCommand("TaylorDiagram")

        ucrBase.clsRsyntax.SetBaseRFunction(clsTaylorDiagramFunction)
    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRcodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverSingleObserved.IsEmpty() OrElse ucrReceiverSingleEstimate.IsEmpty() OrElse Not ucrSavePlot.IsComplete Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrReceiverSingleObserved_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSingleObserved.ControlContentsChanged, ucrSavePlot.ControlContentsChanged, ucrReceiverSingleEstimate.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class