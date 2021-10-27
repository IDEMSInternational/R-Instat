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
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 3

        ucrSelectorTaylorDiagram.SetParameter(New RParameter("mydata", 0))
        ucrSelectorTaylorDiagram.SetParameterIsrfunction()

        ucrReceiverObserved.SetParameter(New RParameter("obs", 1))
        ucrReceiverObserved.Selector = ucrSelectorTaylorDiagram
        ucrReceiverObserved.SetParameterIsString()
        ucrReceiverObserved.SetIncludedDataTypes({"numeric"})
        ucrReceiverObserved.strSelectorHeading = "Numerics"

        ucrReceiverEstimated.SetParameter(New RParameter("mod", 2))
        ucrReceiverEstimated.Selector = ucrSelectorTaylorDiagram
        ucrReceiverEstimated.SetParameterIsString()
        ucrReceiverEstimated.SetIncludedDataTypes({"numeric"})
        ucrReceiverEstimated.strSelectorHeading = "Numerics"

        ucrReceiverGroup.SetParameter(New RParameter("group", 3))
        ucrReceiverGroup.Selector = ucrSelectorTaylorDiagram
        ucrReceiverGroup.SetParameterIsString()
        ucrReceiverGroup.SetIncludedDataTypes({"factor", "character"})
        ucrReceiverGroup.strSelectorHeading = "Factors & Characters"
        ucrReceiverGroup.bExcludeFromSelector = True

        ucrReceiverType.SetParameter(New RParameter("type", 4))
        ucrReceiverType.Selector = ucrSelectorTaylorDiagram
        ucrReceiverType.SetParameterIsString()
        ucrReceiverType.bExcludeFromSelector = True

        ucrChkNormalise.SetParameter(New RParameter("normalise", 5))
        ucrChkNormalise.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkNormalise.SetText("Normalise")
        ucrChkNormalise.SetRDefault("FALSE")

        ucrSavePlot.SetPrefix("taylor_diagram_plot")
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
        ucrReceiverObserved.SetMeAsReceiver()

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
        If ucrReceiverObserved.IsEmpty() OrElse ucrReceiverEstimated.IsEmpty() OrElse ucrReceiverEstimated.Count > 2 OrElse Not ucrSavePlot.IsComplete Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverObserved.ControlContentsChanged, ucrSavePlot.ControlContentsChanged, ucrReceiverEstimated.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverEstimated_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverEstimated.ControlContentsChanged
        If ucrReceiverEstimated.Count > 2 Then
            MsgBox("Note: estimated variables can only be two i.e. two lots of model predictions. Extra variables will be removed.", MsgBoxStyle.Exclamation)
            For i As Integer = ucrReceiverEstimated.Count - 1 To 0 Step -1
                If i > 1 Then
                    ucrReceiverEstimated.lstSelectedVariables.Items(i).Remove()
                End If
            Next
            TestOkEnabled()
        End If
    End Sub
End Class