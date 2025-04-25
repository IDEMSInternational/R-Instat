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
Public Class sdgDefineTricotData
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private lstReceiversLevelID As New List(Of ucrReceiverSingle)
    Private lstRecognisedTypes As New List(Of KeyValuePair(Of String, List(Of String)))

    Private clsGetColumnSelection, clsTricotDataFunction As New RFunction

    Private ReadOnly strPos As String = "_pos"
    Private ReadOnly strBest As String = "_best"
    Private ReadOnly strNeg As String = "_neg"
    Private ReadOnly strWorst As String = "_worst"
    Private ReadOnly strNot As String = "Not Observed"
    Private ReadOnly strMissing As String = "Missing"
    Private ReadOnly strNA As String = "NA"

    Private Sub sdgDefineTricotData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        'SetRCodeForControls(bReset)
        bReset = False
    End Sub

    Private Sub InitialiseDialog()

        Dim kvpID As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("id", {"id", "ID", "participant_id", "participant_name"}.ToList())

        lstRecognisedTypes.AddRange({kvpID})
        lstReceiversLevelID.AddRange({ucrReceiverTricotData})

        ucrSelectorTricotData.SetParameter(New RParameter("id_level_data", 0))
        ucrSelectorTricotData.SetParameterIsString()

        ucrInputGoodTrait.SetItems({strPos, strBest})
        ucrInputGoodTrait.SetDropDownStyleAsNonEditable()
        ucrInputGoodTrait.SetLinkedDisplayControl(lblGoodtrait)

        ucrInputBadTrait.SetItems({strNeg, strWorst})
        ucrInputBadTrait.SetDropDownStyleAsNonEditable()
        ucrInputBadTrait.SetLinkedDisplayControl(lblBadTrait)

        ucrInputNAs.SetItems({strNot, strMissing, strNA})
        ucrInputNAs.SetDropDownStyleAsNonEditable()
        ucrInputNAs.SetLinkedDisplayControl(lblNAs)
        'AutoFillReceivers(ucrSelectorTricotData, lstReceiversLevelID)
    End Sub

    Private Sub SetDefaults()
        clsGetColumnSelection = New RFunction
        clsTricotDataFunction = New RFunction

        ucrReceiverTricotData.SetMeAsReceiver()

        clsTricotDataFunction.SetPackageName("databook")
        clsTricotDataFunction.SetRCommand("create_tricot_data")
        clsTricotDataFunction.AddParameter("output_data_levels", "NULL")
        clsTricotDataFunction.AddParameter("id_level_data", ucrSelectorTricotData.strCurrentDataFrame)
        clsTricotDataFunction.AddParameter("id_col", ucrReceiverTricotData.GetVariableNames)
        clsTricotDataFunction.AddParameter("good_suffixes", ucrInputGoodTrait.GetText)
    End Sub

End Class