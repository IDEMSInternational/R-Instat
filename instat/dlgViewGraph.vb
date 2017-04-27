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

Public Class dlgViewGraph
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsGgplotly, clsGetGraphs As New RFunction
    Private Sub dlgViewGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOkEnabled()
    End Sub

    Private Sub SetDefaults()
        clsGgplotly = New RFunction

        ucrGraphsSelector.Reset()
        ucrSaveGraph.Reset()

        clsGgplotly.SetPackageName("plotly")
        clsGgplotly.SetRCommand("ggplotly")

        clsGetGraphs.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_graphs")
        clsGetGraphs.SetAssignTo("last_graph", strTempDataframe:=ucrGraphsSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseRFunction(clsGetGraphs)
    End Sub

    Private Sub InitialiseDialog()
        'TODO HELPID
        rdoDisplaySeparateWindow.Enabled = False
        'Selector
        ucrGraphsSelector.SetParameter(New RParameter("data_name", 0))
        ucrGraphsSelector.SetParameterIsString()

        'Receiver
        ucrGraphReceiver.SetParameter(New RParameter("graph_name", 1))
        ucrGraphReceiver.strSelectorHeading = "Graphs"
        ucrGraphReceiver.SetParameterIsString()
        ucrGraphReceiver.SetItemType("graph")
        ucrGraphReceiver.Selector = ucrGraphsSelector
        ucrGraphReceiver.SetMeAsReceiver()

        'Group Options panel
        ucrPnlDisplayOptions.AddRadioButton(rdoDisplayOutputWindow)
        ucrPnlDisplayOptions.AddRadioButton(rdoDisplayRViewer)
        'ucrPnlDisplayOptions.AddRadioButton(rdoDisplaySeparateWindow)
        ucrPnlDisplayOptions.AddRadioButton(rdoDisplayInteractiveView)

        ucrPnlDisplayOptions.AddFunctionNamesCondition(rdoDisplayOutputWindow, frmMain.clsRLink.strInstatDataObject & "$get_graphs")
        ucrPnlDisplayOptions.AddFunctionNamesCondition(rdoDisplayRViewer, frmMain.clsRLink.strInstatDataObject & "$get_graphs")
        'ucrPnlDisplayOptions.AddFunctionNamesCondition(rdoDisplaySeparateWindow)
        ucrPnlDisplayOptions.AddFunctionNamesCondition(rdoDisplayInteractiveView, "plotly::ggplotly")

        'ucrSave
        ucrSaveGraph.SetPrefix("UseGraph")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrGraphsSelector.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        Dim clsParam As RParameter
        clsParam = New RParameter("p", 0)
        ucrGraphReceiver.AddAdditionalCodeParameterPair(clsGgplotly, clsParam, iAdditionalPairNo:=1)

        ucrGraphReceiver.SetRCode(clsGetGraphs, bReset)
        ucrSaveGraph.SetRCode(clsGetGraphs, bReset)
        ucrGraphsSelector.SetRCode(clsGetGraphs, bReset)
        ucrPnlDisplayOptions.SetRCode(clsGetGraphs, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrGraphReceiver.IsEmpty OrElse ucrSaveGraph.IsComplete() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        If rdoDisplayOutputWindow.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsGetGraphs)
            ucrBase.clsRsyntax.iCallType = 3
        ElseIf rdoDisplayRViewer.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsGetGraphs)
            ucrBase.clsRsyntax.iCallType = 2
        ElseIf rdoDisplayInteractiveView.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsGgplotly)
            ucrBase.clsRsyntax.bHTMLOutput = True
            ucrBase.clsRsyntax.iCallType = 3
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrGraphReceiver.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class