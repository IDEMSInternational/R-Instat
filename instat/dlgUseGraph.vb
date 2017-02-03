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
Public Class dlgUseGraph
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    'Public clsLeftCommand As New RFunction

    Private Sub dlgUseGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub SetRCodeForControls(breset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, breset)
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction

        ucrGraphReceiver.SetMeAsReceiver()
        ucrGraphsSelector.Reset()
        ucrSaveGraph.Reset()

        'Disabling this button temporarily before we get to subdialog for graphics sorted 
        cmdPlotOptions.Enabled = False

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_graphs")
        clsDefaultFunction.SetAssignTo("last_graph", strTempDataframe:=ucrGraphsSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())

        TestOkEnabled()
    End Sub
    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 430
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3


        ucrGraphsSelector.SetParameter(New RParameter("data_name", 0))
        ucrGraphsSelector.SetParameterIsString()

        ucrGraphsSelector.SetItemType("graph")
        ucrGraphReceiver.Selector = ucrGraphsSelector
        ucrGraphReceiver.SetParameter(New RParameter("graph_name", 1))
        ucrGraphReceiver.strSelectorHeading = "Graphs"
        ucrGraphReceiver.SetParameterIsString()

        'ucrBase.clsRsyntax.SetOperation("+")
        'sdgPlots.SetRSyntax(ucrBase.clsRsyntax)

        ucrSaveGraph.SetPrefix("UseGraph")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrGraphsSelector.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub TestOkEnabled()
        If ucrGraphReceiver.IsEmpty OrElse Not ucrSaveGraph.IsComplete() Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub
    Private Sub cmdPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdPlotOptions.Click
        sdgPlots.ShowDialog()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrGraphsSelector.ControlContentsChanged, ucrGraphReceiver.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class