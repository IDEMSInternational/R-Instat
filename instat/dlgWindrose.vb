
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
Imports instat
Imports instat.Translations
Public Class dlgWindrose
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDefaultRFunction As New RFunction
    Private Sub dlgWindrose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub
    Private Sub InitialiseDialog()

        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.iHelpTopicID = 452
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrReceiverWindSpeed.Selector = ucrWindRoseSelector
        ucrReceiverWindSpeed.SetParameter(New RParameter("speed"))
        ucrReceiverWindSpeed.SetIncludedDataTypes({"numeric"})
        ucrReceiverWindSpeed.SetParameterIsRFunction()

        ucrReceiverWindDirection.Selector = ucrWindRoseSelector
        ucrReceiverWindDirection.SetParameter(New RParameter("direction"))
        ucrReceiverWindDirection.SetIncludedDataTypes({"numeric"})
        ucrReceiverWindDirection.SetParameterIsRFunction()

        ucrReceiverFacet.Selector = ucrWindRoseSelector
        ucrReceiverFacet.SetIncludedDataTypes({"factor"})
        ucrReceiverFacet.SetParameter(New RParameter("facet"))
        ucrReceiverFacet.SetParameterIsRFunction()

        ucrNudNoOfColumns.SetParameter(New RParameter(""))
        ucrNudNoOfColumns.SetLinkedDisplayControl(lblNoOfColumns)

        ucrSaveGraph.SetPrefix("Windrose")
        ucrSaveGraph.SetDataFrameSelector(ucrWindRoseSelector.ucrAvailableDataFrames)
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetCheckBoxText("Save graph")
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsDefaultRFunction = New RFunction

        ucrWindRoseSelector.Reset()
        ucrSaveGraph.Reset()
        ucrReceiverWindSpeed.SetMeAsReceiver()

        clsDefaultRFunction.SetRCommand("windrose")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultRFunction)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverWindSpeed.IsEmpty AndAlso Not ucrReceiverWindDirection.IsEmpty AndAlso ucrSaveGraph.IsComplete Then
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
End Class