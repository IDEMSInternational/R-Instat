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

        ucrReceiverSingleObserved.SetParameter(New RParameter("obs", 1))
        ucrReceiverSingleObserved.Selector = ucrSelectorTaylorDiagram
        ucrReceiverSingleObserved.SetParameterIsString()
        ucrReceiverSingleObserved.SetIncludedDataTypes({"numeric"})
        ucrReceiverSingleObserved.strSelectorHeading = "Numerics"

        ucrReceiverSingleEstimated.SetParameter(New RParameter("mod", 2))
        ucrReceiverSingleEstimated.Selector = ucrSelectorTaylorDiagram
        ucrReceiverSingleEstimated.SetParameterIsString()
        ucrReceiverSingleEstimated.SetIncludedDataTypes({"numeric"})
        ucrReceiverSingleEstimated.strSelectorHeading = "Numerics"

        ucrReceiverMultipleGroup.SetParameter(New RParameter("group", 3))
        ucrReceiverMultipleGroup.Selector = ucrSelectorTaylorDiagram
        ucrReceiverMultipleGroup.SetParameterIsString()
        ucrReceiverMultipleGroup.SetIncludedDataTypes({"factor", "character"})
        ucrReceiverMultipleGroup.strSelectorHeading = "Factors & Characters"
        ucrReceiverMultipleGroup.bExcludeFromSelector = True

        ucrReceiverSingleStation.SetParameter(New RParameter("type", 4))
        ucrReceiverSingleStation.Selector = ucrSelectorTaylorDiagram
        ucrReceiverSingleStation.SetParameterIsString()
        ucrReceiverSingleStation.bExcludeFromSelector = True
        ucrReceiverSingleStation.SetClimaticType("station")
        ucrReceiverSingleStation.bAutoFill = True

        ucrChkNormalise.SetParameter(New RParameter("normalise", 5))
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
        ucrReceiverSingleObserved.SetMeAsReceiver()

        clsTaylorDiagramFunction.SetPackageName("openair")
        clsTaylorDiagramFunction.SetRCommand("TaylorDiagram")
        clsTaylorDiagramFunction.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorTaylorDiagram.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

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
        If ucrReceiverSingleObserved.IsEmpty() OrElse ucrReceiverSingleEstimated.IsEmpty() OrElse Not ucrSavePlot.IsComplete Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrReceiverSingleObserved_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSingleObserved.ControlContentsChanged, ucrSavePlot.ControlContentsChanged, ucrReceiverSingleEstimated.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class