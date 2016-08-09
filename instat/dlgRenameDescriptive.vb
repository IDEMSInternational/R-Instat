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
Imports instat.Translations
Public Class dlgRenameDescriptive
    Public bFirstLoad As Boolean = True
    Dim bUseSelectedObject As Boolean = False
    Dim strSelectedOject As String = ""
    Dim strSelectedDataFrame As String = ""
    Private Sub dlgRenameDescriptive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()
        ucrReceiverCurrentName.txtReceiverSingle.Clear()
        ucrInputNewName.txtInput.Clear()
    End Sub
    Private Sub TestOKEnabled()
        If ((Not ucrReceiverCurrentName.IsEmpty) And (Not ucrInputNewName.IsEmpty)) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverCurrentName.Selector = ucrSelectorForRenameObject
        ucrReceiverCurrentName.SetMeAsReceiver()
        ucrSelectorForRenameObject.SetItemType("object")
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$rename_object")
        ucrBase.iHelpTopicID = 350
    End Sub

    Private Sub SetDefaults()
        ucrSelectorForRenameObject.Reset()
        ucrInputNewName.ResetText()
    End Sub

    Public Sub SetCurrentObject(strColumn As String, strDataFrame As String)
        strSelectedOject = strColumn
        strSelectedDataFrame = strDataFrame
        bUseSelectedObject = True
    End Sub

    Private Sub SetDefaultOject()
        ucrSelectorForRenameObject.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem = strSelectedDataFrame
        ucrReceiverCurrentName.Add(strSelectedOject, strSelectedDataFrame)
        bUseSelectedObject = False
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorForRenameObject_DataFrameChanged() Handles ucrSelectorForRenameObject.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorForRenameObject.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub ucrReceiverCurrentName_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverCurrentName.SelectionChanged
        If Not ucrReceiverCurrentName.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("object_name", ucrReceiverCurrentName.GetVariableNames)
            ucrInputNewName.SetName(ucrReceiverCurrentName.GetVariableNames(bWithQuotes:=False))
        Else
            ucrBase.clsRsyntax.RemoveParameter("object_name")
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrInputNewName_NameChanged() Handles ucrInputNewName.NameChanged
        If Not ucrInputNewName.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("new_name", Chr(34) & ucrInputNewName.GetText & Chr(34))
        Else
            ucrBase.clsRsyntax.RemoveParameter("new_name")
        End If
    End Sub
End Class