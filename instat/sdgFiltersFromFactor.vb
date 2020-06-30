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
    Public strDataFrame As String
    Public clsFilterFunction As RFunction
    Public clsConditionsList As RFunction
    Private Sub sdgFiltersFromFactor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()

        ucrFactorReceiver.Selector = ucrFactorSelctor
        ucrFactorReceiver.SetIncludedDataTypes({"factor"})
        ucrFactorReceiver.strSelectorHeading = "Factors"
        ucrFactorReceiver.SetParameter(New RParameter("x", 0))
        ucrFactorReceiver.SetMeAsReceiver()
        ucrFactorReceiver.SetParameterIsRFunction()
        ucrFactorReceiver.bWithQuotes = False

        ucrFactorLevel.SetAsMultipleSelector()
        ucrFactorLevel.SetReceiver(ucrFactorReceiver)
        ucrFactorLevel.SetIncludeLevels(False)
        ucrFactorLevel.bIncludeNA = True

        cmdToggleSelectAll.Visible = True

        ucrFactorSelctor.SetParameter(New RParameter("factors", 0))
        ucrFactorSelctor.SetParameterIsrfunction()


        ucrChkAndExistingFilter.SetText("AndExistingFilter")
        ucrChkAndExistingFilter.AddToLinkedControls(ucrReceiverExistingFilter, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        clsFilterFunction = New RFunction
        clsFilterFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_filter")
        clsConditionsList = New RFunction
        clsConditionsList.SetRCommand("list")
        clsFilterFunction.AddParameter("filter", clsRFunctionParameter:=clsConditionsList)
    End Sub

    Private Sub Setdefaults()
        ucrFactorReceiver.SetMeAsReceiver()
        VariableTypeProperties()

    End Sub

    Private Sub VariableTypeProperties()
        ucrFactorLevel.Visible = False
        cmdToggleSelectAll.Visible = False
    End Sub

    Private Sub SetToggleButtonSettings()
        If ucrFactorLevel.IsAllSelected() Then
            cmdToggleSelectAll.Text = "Deselect All Levels"
            cmdToggleSelectAll.FlatStyle = FlatStyle.Flat
        Else
            cmdToggleSelectAll.Text = "Select All Levels"
            cmdToggleSelectAll.FlatStyle = FlatStyle.Popup
        End If
    End Sub
    Public Sub SetRcode(Optional ucrBaseSelector As ucrSelector = Nothing)
        If ucrBaseSelector IsNot Nothing AndAlso ucrBaseSelector.strCurrentDataFrame <> "" Then
            strDataFrame = ucrBaseSelector.strCurrentDataFrame
            ucrFactorSelctor.SetDataframe(strDataFrame, False)
        End If
    End Sub

    Private Sub ucrFactorSelctor_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrFactorSelctor.ControlValueChanged
        clsFilterFunction.AddParameter("data_name", Chr(34) & ucrFactorSelctor.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
    End Sub
End Class