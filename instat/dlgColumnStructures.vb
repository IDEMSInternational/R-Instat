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
Public Class dlgColumnStructure
    Public clsCourByStructure As New RFunction
    'clsCourByStructure is here to construct the R-command that will colour columns according to their type in case it is required (see relevant tick box).
    Public bFirstLoad As Boolean = True
    Private Sub ucrSelectorColumnStructures_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        SetColumnStructureInReceiver()
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        clsCourByStructure.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_column_colours_by_metadata")
        clsCourByStructure.AddParameter("property", Chr(34) & "Structure" & Chr(34))
        ucrReceiverType2.Selector = ucrSelectorColumnStructure
        ucrReceiverType1.Selector = ucrSelectorColumnStructure
        ucrReceiverType3.Selector = ucrSelectorColumnStructure
        ucrReceiverType1.bExcludeFromSelector = True
        ucrReceiverType3.bExcludeFromSelector = True
        ucrReceiverType2.bExcludeFromSelector = True
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$set_structure_columns")
    End Sub

    Private Sub SetDefaults()
        SetColumnStructureInReceiver()
        ucrReceiverType1.SetMeAsReceiver()
        chkColourColumnsByStr.Checked = False
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetColumnStructureInReceiver()
        ucrReceiverType1.AddItemsWithMetadataProperty(ucrSelectorColumnStructure.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Structure", {"structure_type_1_label"})
        ucrReceiverType2.AddItemsWithMetadataProperty(ucrSelectorColumnStructure.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Structure", {"structure_type_2_label"})
        ucrReceiverType3.AddItemsWithMetadataProperty(ucrSelectorColumnStructure.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Structure", {"structure_type_3_label"})
        ucrReceiverType1.SetMeAsReceiver()
    End Sub

    Private Sub TestOKEnabled()
        If (Not ucrReceiverType1.IsEmpty) OrElse (Not ucrReceiverType2.IsEmpty) OrElse (Not ucrReceiverType3.IsEmpty) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverForColumnStructure_SelectionChanged() Handles ucrReceiverType1.SelectionChanged, ucrReceiverType3.SelectionChanged, ucrReceiverType2.SelectionChanged
        StructureParameters()
        TestOKEnabled()
    End Sub

    Private Sub StructureParameters()
        If Not ucrReceiverType1.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("struc_type_1", ucrReceiverType1.GetVariableNames)
        Else
            ucrBase.clsRsyntax.RemoveParameter("struc_type_1")
        End If
        If Not ucrReceiverType2.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("struc_type_2", ucrReceiverType2.GetVariableNames)
        Else
            ucrBase.clsRsyntax.RemoveParameter("struc_type_2")
        End If
        If Not ucrReceiverType3.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("struc_type_3", ucrReceiverType3.GetVariableNames)
        Else
            ucrBase.clsRsyntax.RemoveParameter("struc_type_3")
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorColumnStructure_DataFrameChanged() Handles ucrSelectorColumnStructure.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorColumnStructure.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        clsCourByStructure.AddParameter("data_name", Chr(34) & ucrSelectorColumnStructure.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        SetColumnStructureInReceiver()
    End Sub


    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        If chkColourColumnsByStr.Checked Then
            frmMain.clsRLink.RunScript(clsCourByStructure.ToScript())
        End If
    End Sub
End Class