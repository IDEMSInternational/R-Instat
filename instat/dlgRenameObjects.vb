﻿' R- Instat
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
Public Class dlgRenameObjects
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Dim bUseSelectedColumn As Boolean = False
    Dim strSelectedColumn As String = ""
    Dim strSelectedDataFrame As String = ""
    Private clsDefaultFunction As New RFunction

    Private Sub dlgRenameObjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        TestOKEnabled()
        If bUseSelectedColumn Then
            SetDefaultColumn()
        End If
        autoTranslate(Me)
    End Sub

    Private Sub ReopenDialog()
        ' temp. fix, the receivers should clear only if the name of the object in it has changed
        ucrSelectorForRenameObject.Reset()
        ucrInputNewName.SetName("")
    End Sub

    Private Sub InitialiseDialog()
        Dim dctType As New Dictionary(Of String, String)
        ucrBase.iHelpTopicID = 350

        'ucrSelector
        ucrSelectorForRenameObject.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForRenameObject.SetParameterIsString()

        'ucrReceiver
        ucrReceiverCurrentName.SetParameter(New RParameter("object_name", 1))
        ucrReceiverCurrentName.Selector = ucrSelectorForRenameObject
        ucrReceiverCurrentName.SetMeAsReceiver()
        ucrReceiverCurrentName.SetParameterIsString()

        'ucrNewName
        ucrInputNewName.SetParameter(New RParameter("new_name", 2))
        ucrInputNewName.SetValidationTypeAsRVariable()

        ucrInputType.SetParameter(New RParameter("object_type", 3))
        dctType.Add("Objects", Chr(34) & "object" & Chr(34))
        dctType.Add("Filters", Chr(34) & "filter" & Chr(34))
        dctType.Add("Calculations", Chr(34) & "calculation" & Chr(34))
        dctType.Add("Tables", Chr(34) & "table" & Chr(34))
        dctType.Add("Graphs", Chr(34) & "graph" & Chr(34))
        dctType.Add("Models", Chr(34) & "model" & Chr(34))
        ucrInputType.SetItems(dctType)
        ucrInputType.SetDropDownStyleAsNonEditable()
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction

        ucrSelectorForRenameObject.Reset()

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$rename_object")
        clsDefaultFunction.AddParameter("object_type", Chr(34) & "object" & Chr(34), iPosition:=3)
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If (Not ucrReceiverCurrentName.IsEmpty) AndAlso (Not ucrInputNewName.IsEmpty) AndAlso (ucrReceiverCurrentName.GetVariableNames(bWithQuotes:=False) <> ucrInputNewName.GetText) AndAlso (ucrSelectorForRenameObject.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "") Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Public Sub SetCurrentColumn(strcolumn As String, strdataframe As String)
        strSelectedColumn = strcolumn
        strSelectedDataFrame = strdataframe
        bUseSelectedColumn = True
    End Sub

    Private Sub SetDefaultColumn()
        ucrSelectorForRenameObject.SetDataframe(strSelectedDataFrame)
        ucrReceiverCurrentName.Add(strSelectedColumn, strSelectedDataFrame)
        bUseSelectedColumn = False
    End Sub

    Private Sub ucrReceiverCurrentName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverCurrentName.ControlValueChanged
        If Not ucrReceiverCurrentName.IsEmpty AndAlso Not ucrInputNewName.bUserTyped Then
            ucrInputNewName.SetName(ucrReceiverCurrentName.GetVariableNames(bWithQuotes:=False) & "1")
        End If
    End Sub

    Private Sub ucrInputType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputType.ControlValueChanged
        Select Case ucrInputType.GetValue()
            Case "Objects"
                ucrReceiverCurrentName.SetItemType("object")
                ucrReceiverCurrentName.strSelectorHeading = "Objects"
            Case "Filters"
                ucrReceiverCurrentName.SetItemType("filter")
                ucrReceiverCurrentName.strSelectorHeading = "Filters"
            Case "Calculations"
                ucrReceiverCurrentName.SetItemType("calculation")
                ucrReceiverCurrentName.strSelectorHeading = "Calculations"
            Case "Tables"
                ucrReceiverCurrentName.SetItemType("table")
                ucrReceiverCurrentName.strSelectorHeading = "Tables"
            Case "Graphs"
                ucrReceiverCurrentName.SetItemType("graph")
                ucrReceiverCurrentName.strSelectorHeading = "Graphs"
            Case "Models"
                ucrReceiverCurrentName.SetItemType("model")
                ucrReceiverCurrentName.strSelectorHeading = "Models"
        End Select
    End Sub

    Private Sub CoreControls_ContentsChanged() Handles ucrInputNewName.ControlContentsChanged, ucrSelectorForRenameObject.ControlContentsChanged, ucrReceiverCurrentName.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class