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
    Public bFirstLoad As Boolean = True
    Private Sub ucrSelectorColumnStructures_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        If bFirstLoad Then
            SetDefaults()
            InitialiseDialog()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        SetColumnStructureInReceiver()
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverTreatment.Selector = ucrSelectorColumnStructure
        ucrReceiverForLayout.Selector = ucrSelectorColumnStructure
        ucrReceiverMeasurement.Selector = ucrSelectorColumnStructure
        ucrReceiverForLayout.SetMeAsReceiver()
        ucrReceiverForLayout.bExcludeFromSelector = True
        ucrReceiverMeasurement.bExcludeFromSelector = True
        ucrReceiverTreatment.bExcludeFromSelector = True
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$set_structure_columns")
    End Sub

    Private Sub SetDefaults()
        ' ucrSelectorColumnStructure.Reset()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetColumnStructureInReceiver()
        'ucrSelectorColumnStructure.Reset()
        ucrSelectorColumnStructure.AddItemsWithMetadataProperty("Structure", {Chr(34) & "Treatment" & Chr(34), Chr(34) & "Measurement" & Chr(34), Chr(34) & "Layout" & Chr(34)})
    End Sub

    Private Sub TestOKEnabled()
        If ucrReceiverForLayout.IsEmpty() = False Or ucrReceiverMeasurement.IsEmpty() = False Or ucrReceiverTreatment.IsEmpty() = False Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetColumnStructureInReceiver()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverForColumnStructure_SelectionChanged() Handles ucrReceiverForLayout.SelectionChanged, ucrReceiverMeasurement.SelectionChanged, ucrReceiverTreatment.SelectionChanged
        StructureParameters()
    End Sub

    Private Sub StructureParameters()
        If ucrReceiverForLayout.IsEmpty = False Then
            ucrBase.clsRsyntax.AddParameter("struc_type_2", ucrReceiverTreatment.GetVariableNames)
        Else
            ucrBase.clsRsyntax.RemoveParameter("struc_type_2")
        End If
        If ucrReceiverMeasurement.IsEmpty = False Then
            ucrBase.clsRsyntax.AddParameter("struc_type_3", ucrReceiverMeasurement.GetVariableNames)
        Else
            ucrBase.clsRsyntax.RemoveParameter("struc_type_3")
        End If

        If ucrReceiverTreatment.IsEmpty = False Then
            ucrBase.clsRsyntax.AddParameter("struc_type_1", ucrReceiverForLayout.GetVariableNames)
        Else
            ucrBase.clsRsyntax.RemoveParameter("struc_type_1")
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorColumnStructure_DataFrameChanged() Handles ucrSelectorColumnStructure.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorColumnStructure.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub
End Class