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
Public Class dlgCombineforGraphics
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubDialog As Boolean = False
    Private clsDefaultRFunction As New RFunction
    Private Sub dlgCombineforGraphics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.iHelpTopicID = 431
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrCombineGraphReceiver.SetParameter(New RParameter("grobs", 0))
        ucrCombineGraphReceiver.SetParameterIsRFunction()
        ucrCombineGraphReceiver.Selector = ucrCombineGraphSelector
        ucrCombineGraphReceiver.SetItemType("graph")
        ucrCombineGraphReceiver.strSelectorHeading = "Graphs"

        ucrSave.SetPrefix("combined_graph")
        ucrSave.SetDataFrameSelector(ucrCombineGraphSelector.ucrAvailableDataFrames)
        ucrSave.SetSaveTypeAsGraph()
        ucrSave.SetCheckBoxText("Save Graph")
        ucrSave.SetIsComboBox()
        ucrSave.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsDefaultRFunction = New RFunction

        ucrCombineGraphReceiver.SetMeAsReceiver()
        ucrCombineGraphSelector.Reset()
        ucrSave.Reset()

        clsDefaultRFunction.SetPackageName("gridExtra")
        clsDefaultRFunction.SetRCommand("grid.arrange")
        clsDefaultRFunction.SetAssignTo("last_graph", strTempDataframe:=ucrCombineGraphSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultRFunction)
        bResetSubDialog = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrCombineGraphReceiver.lstSelectedVariables.Items.Count > 1 AndAlso ucrSave.IsComplete Then
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

    Private Sub cmdLayout_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        'this SetRFunction is still empty in subdialog but will be fixed soon.
        sdgCombineGraphOptions.SetRFunction(ucrBase.clsRsyntax.clsBaseFunction, bResetSubDialog)
        sdgCombineGraphOptions.ShowDialog()
        bResetSubDialog = False
    End Sub

    Private Sub AllControls_ControlContentsChanged() Handles ucrCombineGraphReceiver.ControlContentsChanged, ucrSave.ControlContentsChanged
        TestOkEnabled()
    End Sub
    Private Sub AllControl_ControlContentsChanged() Handles ucrCombineGraphReceiver.ControlContentsChanged
        sdgCombineGraphOptions.SetDefaultRowAndColumns()
    End Sub
End Class