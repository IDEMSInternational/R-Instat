'R-Instat
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

Public Class dlgPolarCluster
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    'Functions 
    Private clsPolarClusterFunction As RFunction

    Private Sub dlgPolarCluster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim dctColor As New Dictionary(Of String, String)

        ucrBase.clsRsyntax.iCallType = 3

        ucrSelectorPolarCluster.SetParameter(New RParameter("mydata", 0))
        ucrSelectorPolarCluster.SetParameterIsrfunction()

        ucrReceiverPollutant.SetParameter(New RParameter("pollutant", 1))
        ucrReceiverPollutant.Selector = ucrSelectorPolarCluster
        ucrReceiverPollutant.SetParameterIsString()

        ucrReceiverWindDirection.SetParameter(New RParameter("wd", 2))
        ucrReceiverWindDirection.Selector = ucrSelectorPolarCluster
        ucrReceiverWindDirection.SetParameterIsString()

        ucrReceiverX.SetParameter(New RParameter("x", 3))
        ucrReceiverX.Selector = ucrSelectorPolarCluster
        ucrReceiverX.SetParameterIsString()

        ucrReceiverDate.SetParameter(New RParameter("date", 4))
        ucrReceiverDate.Selector = ucrSelectorPolarCluster
        ucrReceiverDate.SetParameterIsString()

        ucrInputColor.SetParameter(New RParameter("cols", 5))
        dctColor.Add("Paired", Chr(34) & "Paired" & Chr(34))
        dctColor.Add("Accent", Chr(34) & "Accent" & Chr(34))
        dctColor.Add("Dark2", Chr(34) & "Dark2" & Chr(34))
        dctColor.Add("Pastel1", Chr(34) & "Pastel1" & Chr(34))
        dctColor.Add("Pastel2", Chr(34) & "Pastel2" & Chr(34))
        dctColor.Add("Set1", Chr(34) & "Set1" & Chr(34))
        dctColor.Add("Set2", Chr(34) & "Set2" & Chr(34))
        dctColor.Add("Set3", Chr(34) & "Set3" & Chr(34))
        ucrInputColor.SetItems(dctColor)
        ucrInputColor.SetDropDownStyleAsNonEditable()

        ucrNudAngularScale.SetParameter(New RParameter("angle", 6))
        ucrNudAngularScale.SetMinMax(0, 360)

        ucrNudNoOfClusters.SetParameter(New RParameter("n.clusters", 7))
        ucrNudNoOfClusters.Minimum = 1

        ucrSaveGraph.SetPrefix("polarcluster")
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorPolarCluster.ucrAvailableDataFrames)
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()

        clsPolarClusterFunction = New RFunction

        clsPolarClusterFunction.AddParameter("cols", Chr(34) & "Paired" & Chr(34), iPosition:=5)
        clsPolarClusterFunction.AddParameter("angle", "45", iPosition:=6)
        clsPolarClusterFunction.AddParameter("n.clusters", "6", iPosition:=7)

        ucrSelectorPolarCluster.Reset()
        ucrReceiverPollutant.SetMeAsReceiver()
        ucrSaveGraph.Reset()

        clsPolarClusterFunction.SetPackageName("openair")
        clsPolarClusterFunction.SetRCommand("polarCluster")

        ucrBase.clsRsyntax.SetBaseRFunction(clsPolarClusterFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverPollutant.IsEmpty OrElse ucrReceiverWindDirection.IsEmpty OrElse ucrReceiverX.IsEmpty OrElse ucrReceiverDate.IsEmpty Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverPollutant_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverPollutant.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrReceiverWindDirection.ControlContentsChanged, ucrReceiverX.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class
