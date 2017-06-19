
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
Imports RDotNet
Imports instat.Translations
Public Class dlgWindrose
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubDialog As Boolean = False
    Private clsDefaultRFunction As New RFunction
    Private clsFactorColumn As New RFunction
    Private clsLevelofFactor As New RFunction

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

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.iHelpTopicID = 452
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrNudNoOfColumns.Visible = False ' temporarily disabled

        ucrReceiverWindSpeed.SetParameter(New RParameter("speed", 0))
        ucrReceiverWindSpeed.Selector = ucrWindRoseSelector
        ucrReceiverWindSpeed.SetIncludedDataTypes({"numeric"})
        ucrReceiverWindSpeed.strSelectorHeading = "Numerics"
        ucrReceiverWindSpeed.SetParameterIsRFunction()

        ucrReceiverWindDirection.SetParameter(New RParameter("direction", 1))
        ucrReceiverWindDirection.Selector = ucrWindRoseSelector
        ucrReceiverWindDirection.SetIncludedDataTypes({"numeric"})
        ucrReceiverWindDirection.strSelectorHeading = "Numerics"
        ucrReceiverWindDirection.SetParameterIsRFunction()

        ucrReceiverFacet.SetParameter(New RParameter("facet", 2))
        ucrReceiverFacet.Selector = ucrWindRoseSelector
        ucrReceiverFacet.SetIncludedDataTypes({"factor"})
        ucrReceiverFacet.strSelectorHeading = "Factors"
        ucrReceiverFacet.SetParameterIsRFunction()

        ucrNudNoOfColumns.SetParameter(New RParameter("n_col", 7))
        ucrNudNoOfColumns.SetLinkedDisplayControl(lblNoOfColumns)
        ucrNudNoOfColumns.SetRDefault(1)
        ucrNudNoOfColumns.Minimum = 1

        ucrSaveGraph.SetPrefix("windrose")
        ucrSaveGraph.SetDataFrameSelector(ucrWindRoseSelector.ucrAvailableDataFrames)
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsDefaultRFunction = New RFunction

        ucrWindRoseSelector.Reset()
        ucrSaveGraph.Reset()
        ucrReceiverWindSpeed.SetMeAsReceiver()

        clsDefaultRFunction.SetPackageName("clifro")
        clsDefaultRFunction.SetRCommand("windrose")
        clsDefaultRFunction.AddParameter("ggtheme", Chr(34) & "minimal" & Chr(34))
        clsDefaultRFunction.SetAssignTo("last_graph", strTempDataframe:=ucrWindRoseSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultRFunction)
        bResetSubDialog = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverWindSpeed.IsEmpty AndAlso Not ucrReceiverWindDirection.IsEmpty AndAlso ucrSaveGraph.IsComplete AndAlso ((Not ucrReceiverFacet.IsEmpty AndAlso ucrNudNoOfColumns.GetText <> "") OrElse ucrReceiverFacet.IsEmpty) Then
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

    Private Sub cmdWindroseOptions_Click(sender As Object, e As EventArgs) Handles cmdWindroseOptions.Click
        sdgWindrose.SetRFunction(ucrBase.clsRsyntax.clsBaseFunction, bResetSubDialog)
        bResetSubDialog = False
        sdgWindrose.ShowDialog()
    End Sub

    Private Sub GetMaxValue()
        Dim iColMax As Integer

        clsLevelofFactor.SetRCommand("nlevels")
        clsFactorColumn.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsFactorColumn.AddParameter("col_name", ucrReceiverFacet.GetVariableNames())
        clsLevelofFactor.AddParameter("x", clsRFunctionParameter:=clsFactorColumn)

        iColMax = frmMain.clsRLink.RunInternalScriptGetValue(clsLevelofFactor.ToScript).AsNumeric(0)
        ucrNudNoOfColumns.Maximum = iColMax
    End Sub

    Private Sub ucrReceiverFacet_ControlValueChanged() Handles ucrReceiverFacet.ControlValueChanged
        GetMaxValue()
        If ucrReceiverFacet.IsEmpty Then
            ucrNudNoOfColumns.Visible = False
        Else
            ucrNudNoOfColumns.Visible = True
        End If
    End Sub

    Private Sub ucrWindRoseSelector_DataFrameChanged() Handles ucrWindRoseSelector.ControlValueChanged
        clsFactorColumn.AddParameter("data_name", Chr(34) & ucrWindRoseSelector.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub ucrReceiverWindSpeed_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverWindSpeed.ControlContentsChanged, ucrReceiverWindDirection.ControlContentsChanged, ucrNudNoOfColumns.ControlContentsChanged, ucrReceiverFacet.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class
