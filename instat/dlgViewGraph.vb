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

Public Class dlgViewGraph
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsggPlotly, clsGetGraphs As New RFunction
    Private strGraphDisplayOption As String

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

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 525
        rdoDisplaySeparateWindow.Enabled = False

        'Selector
        ucrGraphsSelector.SetParameter(New RParameter("data_name", 0))
        ucrGraphsSelector.SetParameterIsString()

        'Receiver
        ucrGraphReceiver.SetParameter(New RParameter("graph_name", 1))
        ucrGraphReceiver.strSelectorHeading = "Ggplot Graphs"
        ucrGraphReceiver.bAutoFill = True
        ucrGraphReceiver.SetParameterIsString()
        ucrGraphReceiver.SetItemType("graph")
        ucrGraphReceiver.Selector = ucrGraphsSelector
        ucrGraphReceiver.SetMeAsReceiver()

        ' We don't specify rdos in the new system here. This is because the automatic detection of the radio buttons relies on VB options, not R code
        'Group Options panel
        ucrPnlDisplayOptions.AddRadioButton(rdoDisplayOutputWindow)
        ucrPnlDisplayOptions.AddRadioButton(rdoDisplayRViewer)
        'ucrPnlDisplayOptions.AddRadioButton(rdoDisplaySeparateWindow) ' TODO: Add code for this
        ucrPnlDisplayOptions.AddRadioButton(rdoDisplayInteractiveView)
    End Sub

    Private Sub SetDefaults()
        clsggPlotly = New RFunction
        clsGetGraphs = New RFunction

        ucrGraphsSelector.Reset()
        rdoDisplayInteractiveView.Checked = True

        clsggPlotly.SetPackageName("plotly")
        clsggPlotly.SetRCommand("ggplotly")
        clsggPlotly.AddParameter("p", clsRFunctionParameter:=clsGetGraphs)

        clsGetGraphs.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_graphs")
        ucrBase.clsRsyntax.SetBaseRFunction(clsggPlotly)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrGraphReceiver.SetRCode(clsGetGraphs, bReset)
        ucrGraphsSelector.SetRCode(clsGetGraphs, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrGraphReceiver.IsEmpty Then
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

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        frmMain.clsInstatOptions.SetGraphDisplayOption(strGraphDisplayOption)
    End Sub

    Private Sub ucrPnlDisplayOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDisplayOptions.ControlValueChanged
        strGraphDisplayOption = frmMain.clsInstatOptions.strGraphDisplayOption
        If rdoDisplayInteractiveView.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsggPlotly)
            ucrBase.clsRsyntax.iCallType = 0
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsGetGraphs)
            ucrBase.clsRsyntax.iCallType = 3
            If rdoDisplayOutputWindow.Checked Then
                frmMain.clsInstatOptions.SetGraphDisplayOption("view_output_window")
            ElseIf rdoDisplayRViewer.Checked Then
                frmMain.clsInstatOptions.SetGraphDisplayOption("view_R_viewer")
            ElseIf rdoDisplaySeparateWindow.Checked Then
                frmMain.clsInstatOptions.SetGraphDisplayOption("view_separate_window")
            End If
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrGraphReceiver.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class