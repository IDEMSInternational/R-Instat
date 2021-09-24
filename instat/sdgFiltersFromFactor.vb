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
Public Class sdgFiltersFromFactor
    Private bFirstLoad As Boolean
    Private bReset As Boolean = True
    Private clsAddFilterFromFactors As RFunction

    Public Sub New()
        'This call is required by the designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call.
        bFirstLoad = True
        clsAddFilterFromFactors = New RFunction
        clsAddFilterFromFactors.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_filter_as_levels")
    End Sub

    Private Sub sdgFiltersFromFactor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseControls()
            bFirstLoad = False
        End If
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()
        ucrSelectorFiltersFromFactors.SetParameterIsString()

        ucrFactorLevels.SetParameter(New RParameter("filter_levels", 1))
        ucrFactorLevels.strSelectorColumnName = "Select Level"
        ucrFactorLevels.SetAsMultipleSelector()
        ucrFactorLevels.SetReceiver(ucrReceiverFactor)
        ucrFactorLevels.SetIncludeLevels(False)

        ucrReceiverFactor.SetParameter(New RParameter("column", 2))
        ucrReceiverFactor.Selector = ucrSelectorFiltersFromFactors
        ucrReceiverFactor.SetParameterIsString()
        ucrReceiverFactor.SetMeAsReceiver()
        ucrReceiverFactor.SetDataType("factor", bStrict:=True)

        cmdSelectAll.Enabled = False
    End Sub

    Public Sub SetRcodeAndDefaultDataFrame(ucrNewBaseSelector As ucrSelector, bReset As Boolean)
        If ucrNewBaseSelector IsNot Nothing AndAlso ucrNewBaseSelector.strCurrentDataFrame <> "" Then
            ucrSelectorFiltersFromFactors.SetDataframe(ucrNewBaseSelector.strCurrentDataFrame, False)
        End If
        ucrReceiverFactor.SetRCode(clsAddFilterFromFactors, bReset)
        ucrFactorLevels.SetRCode(clsAddFilterFromFactors, bReset)

        If bReset Then
            ucrSelectorFiltersFromFactors.Reset()
        End If
    End Sub

    Private Sub ucrBase_ClickReturn(sender As Object, e As EventArgs) Handles ucrBase.ClickReturn
        'TODO: check how to get count of selected items from reogrid, then remove bSilent:=False to avoid errors when no level is selected.
        If Not ucrReceiverFactor.IsEmpty Then
            frmMain.clsRLink.RunScript(clsAddFilterFromFactors.ToScript, strComment:="Filter From Factors subdialog: Created new filter", bSilent:=True)
        End If
    End Sub

    Private Sub cmdSelectAll_Click(sender As Object, e As EventArgs) Handles cmdSelectAll.Click
        ucrFactorLevels.SetSelectionAllLevels(Not ucrFactorLevels.IsAllSelected())
    End Sub

    Private Sub ucrFactorLevels_SelectedLevelChanged() Handles ucrFactorLevels.SelectedLevelChanged
        If ucrFactorLevels.IsAllSelected() Then
            cmdSelectAll.Text = "Deselect All Levels"
            cmdSelectAll.FlatStyle = FlatStyle.Flat
        Else
            cmdSelectAll.Text = "Select All Levels"
            cmdSelectAll.FlatStyle = FlatStyle.Popup
        End If
        autoTranslate(Me)
    End Sub

    Private Sub ucrReceiverFactor_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactor.ControlValueChanged
        cmdSelectAll.Enabled = Not ucrReceiverFactor.IsEmpty
    End Sub

    Private Sub ucrSelectorFiltersFromFactors_DataFrameChanged() Handles ucrSelectorFiltersFromFactors.DataFrameChanged
        clsAddFilterFromFactors.AddParameter("data_name", Chr(34) & ucrSelectorFiltersFromFactors.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
    End Sub
End Class