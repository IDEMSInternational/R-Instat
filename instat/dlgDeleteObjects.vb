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
Public Class dlgDeleteObjects
    Private bFirstLoad As Boolean = True
    Private dctTypes As New Dictionary(Of String, String)
    Private bReset As Boolean = True
    Private clsDeleteRFunction As New RFunction

    Private Sub dlgDeleteObjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 352

        ucrSelectorDeleteObject.SetParameter(New RParameter("data_name", 0))
        ucrSelectorDeleteObject.SetParameterIsString()

        ucrInputComboType.SetParameter(New RParameter("object_type", 2))
        dctTypes.Add("Objects", Chr(34) & "object" & Chr(34))
        dctTypes.Add("Summaries", Chr(34) & RObjectTypeLabel.Summary & Chr(34))
        dctTypes.Add("Tables", Chr(34) & RObjectTypeLabel.Table & Chr(34))
        dctTypes.Add("Graphs", Chr(34) & RObjectTypeLabel.Graph & Chr(34))
        dctTypes.Add("Models", Chr(34) & RObjectTypeLabel.Model & Chr(34))
        dctTypes.Add("Structured", Chr(34) & RObjectTypeLabel.StructureLabel & Chr(34))
        dctTypes.Add("Filters", Chr(34) & "filter" & Chr(34))
        dctTypes.Add("Column selections", Chr(34) & "column_selection" & Chr(34))
        dctTypes.Add("Calculations", Chr(34) & "calculation" & Chr(34))
        ucrInputComboType.SetItems(dctTypes)
        ucrInputComboType.SetDropDownStyleAsNonEditable()

        ucrReceiverObjectsToDelete.SetParameter(New RParameter("object_names", 1))
        ucrReceiverObjectsToDelete.SetParameterIsString()
        ucrReceiverObjectsToDelete.Selector = ucrSelectorDeleteObject
        ucrReceiverObjectsToDelete.SetMeAsReceiver()



    End Sub

    Private Sub SetDefaults()
        clsDeleteRFunction = New RFunction

        ucrSelectorDeleteObject.Reset()

        clsDeleteRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$delete_objects")
        clsDeleteRFunction.AddParameter("object_type", Chr(34) & "object" & Chr(34), iPosition:=2)

        ucrBase.clsRsyntax.SetBaseRFunction(clsDeleteRFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrSelectorDeleteObject.SetRCode(clsDeleteRFunction, bReset)
        ucrInputComboType.SetRCode(clsDeleteRFunction, bReset)
        ucrReceiverObjectsToDelete.SetRCode(clsDeleteRFunction, bReset)
        'SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverObjectsToDelete.IsEmpty Then
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

    Private Sub ucrInputComboType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputComboType.ControlValueChanged
        ucrReceiverObjectsToDelete.Clear()
        If dctTypes.ContainsKey(ucrInputComboType.GetText()) Then
            ucrReceiverObjectsToDelete.strSelectorHeading = ucrInputComboType.GetText()
            ucrReceiverObjectsToDelete.SetItemType(dctTypes.Item(ucrInputComboType.GetText()).Replace(Chr(34), ""))
        End If
    End Sub

    Private Sub ucrReceiverObjectsToDelete_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverObjectsToDelete.ControlContentsChanged
        TestOKEnabled()
    End Sub

End Class
