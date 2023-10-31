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
Public Class dlgRenameObjects
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsRenameRFunction As New RFunction
    Private dctTypes As New Dictionary(Of String, String)

    Private Sub dlgRenameObjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 350

        ucrSelectorForRenameObject.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForRenameObject.SetParameterIsString()

        ucrInputType.SetParameter(New RParameter("object_type", 3))
        dctTypes.Add("Objects", Chr(34) & "object" & Chr(34))
        dctTypes.Add("Summaries", Chr(34) & RObjectTypeLabel.Summary & Chr(34))
        dctTypes.Add("Tables", Chr(34) & RObjectTypeLabel.Table & Chr(34))
        dctTypes.Add("Graphs", Chr(34) & RObjectTypeLabel.Graph & Chr(34))
        dctTypes.Add("Models", Chr(34) & RObjectTypeLabel.Model & Chr(34))
        dctTypes.Add("Structured", Chr(34) & RObjectTypeLabel.StructureLabel & Chr(34))
        dctTypes.Add("Filters", Chr(34) & "filter" & Chr(34))
        dctTypes.Add("Column selections", Chr(34) & "column_selection" & Chr(34))
        dctTypes.Add("Calculations", Chr(34) & "calculation" & Chr(34))
        ucrInputType.SetItems(dctTypes)
        ucrInputType.SetDropDownStyleAsNonEditable()

        ucrReceiverCurrentName.SetParameter(New RParameter("object_name", 1))
        ucrReceiverCurrentName.Selector = ucrSelectorForRenameObject
        ucrReceiverCurrentName.SetMeAsReceiver()
        ucrReceiverCurrentName.SetParameterIsString()

        ucrInputNewName.SetParameter(New RParameter("new_name", 2))
        ucrInputNewName.SetValidationTypeAsRVariable()

    End Sub

    Private Sub SetDefaults()
        clsRenameRFunction = New RFunction

        ucrSelectorForRenameObject.Reset()

        clsRenameRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$rename_object")
        clsRenameRFunction.AddParameter("object_type", Chr(34) & "object" & Chr(34), iPosition:=3)
        ucrBase.clsRsyntax.SetBaseRFunction(clsRenameRFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrSelectorForRenameObject.SetRCode(clsRenameRFunction, bReset)
        ucrInputType.SetRCode(clsRenameRFunction, bReset)
        ucrReceiverCurrentName.SetRCode(clsRenameRFunction, bReset)
        ucrInputNewName.SetRCode(clsRenameRFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If (Not ucrReceiverCurrentName.IsEmpty) AndAlso (Not ucrInputNewName.IsEmpty) AndAlso (ucrReceiverCurrentName.GetVariableNames(bWithQuotes:=False) <> ucrInputNewName.GetText) AndAlso (ucrSelectorForRenameObject.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "") Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub


    Private Sub CoreControls_ContentsChanged() Handles ucrInputNewName.ControlContentsChanged, ucrSelectorForRenameObject.ControlContentsChanged, ucrReceiverCurrentName.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrInputType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputType.ControlValueChanged
        ucrReceiverCurrentName.Clear()
        If dctTypes.ContainsKey(ucrInputType.GetText()) Then
            ucrReceiverCurrentName.strSelectorHeading = ucrInputType.GetText()
            ucrReceiverCurrentName.SetItemType(dctTypes.Item(ucrInputType.GetText()).Replace(Chr(34), ""))
        End If
    End Sub

    Private Sub ucrReceiverCurrentName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverCurrentName.ControlValueChanged
        If Not ucrReceiverCurrentName.IsEmpty AndAlso Not ucrInputNewName.bUserTyped Then
            ucrInputNewName.SetName(ucrReceiverCurrentName.GetVariableNames(bWithQuotes:=False) & "1")
        End If
    End Sub



    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub


End Class