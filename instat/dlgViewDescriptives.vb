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
Public Class dlgViewDescriptives
    Public bFirstLoad As Boolean = True
    Private Sub dlgViewDescriptives_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog
        End If
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverSelectedObject.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If

    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverSelectedObject.Selector = ucrSelectorForViewObject
        ucrReceiverSelectedObject.SetMeAsReceiver()
        ucrSelectorForViewObject.SetItemType("object")
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$get_objects")
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.iHelpTopicID = 349
        rdoAllContents.Enabled = False
        rdoComponent.Enabled = False
        rdoViewGraph.Enabled = False
    End Sub

    Private Sub SetDefaults()
        ucrSelectorForViewObject.Reset()
        rdoStructure.Checked = True
        rdoAllContents.Enabled = False
        ObjectParameters()
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub StructureComponentsAndAllContents_CheckedChanged(sender As Object, e As EventArgs) Handles rdoStructure.CheckedChanged, rdoAllContents.CheckedChanged, rdoComponent.CheckedChanged
        ObjectParameters()
    End Sub

    Private Sub ObjectParameters()
        If rdoStructure.Checked Then

        ElseIf rdoAllContents.Checked Then

        Else

        End If
    End Sub

    Private Sub ucrSelectorForViewObject_DataFrameChaned() Handles ucrSelectorForViewObject.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorForViewObject.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub ucrReceiverSelectedObject_SelectionChnged(sender As Object, e As EventArgs) Handles ucrReceiverSelectedObject.SelectionChanged
        If Not ucrReceiverSelectedObject.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("object_name", ucrReceiverSelectedObject.GetVariableNames())
        Else
            ucrBase.clsRsyntax.RemoveParameter("object_name")
        End If
        TestOKEnabled()
    End Sub

    Private Sub rdoViewGraph_CheckedChanged(sender As Object, e As EventArgs) Handles rdoViewGraph.CheckedChanged
        If rdoViewGraph.Checked Then
            ucrBase.clsRsyntax.iCallType = 0
        Else
            ucrBase.clsRsyntax.iCallType = 2
        End If
    End Sub
End Class