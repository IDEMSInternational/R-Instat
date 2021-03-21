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
Imports RDotNet

Public Class dlgMetadata
    Public clsGetVarMetadata As New RFunction
    Public bFirstLoad As Boolean = True
    Private clsLayerParam As New LayerParameter

    Private Sub dlgMetadata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub InitialiseDialog()
        'TODO change how ucrReceiverMetadataProperty works so that we do not need a LayerParameter
        '     Also need to get current values of metadata to set in ucrReceiverMetadataProperty

        clsLayerParam.strLayerParameterDataType = "list"
        'To be updated, not correct
        'ucrNewValue.SetControls(Nothing, clsLayerParam)
        ucrNewValue.bIsActiveRControl = False

        'ucrReceiverChooseProperty.Selector = ucrSelectByMetadata
        'ucrReceiverChooseColumns.Selector = ucrSelectByMetadata
        'ucrReceiverChooseProperty.SetMeAsReceiver()
        ucrBase.iHelpTopicID = 53
        'ucrReceiverChooseColumns.SetItemType("column")
        'ucrReceiverChooseProperty.SetItemType("metadata")
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$append_to_variables_metadata")
        clsGetVarMetadata.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        ucrCurrentValue.IsReadOnly = True
    End Sub

    Private Sub SetDefaults()
        ucrSelectByMetadata.Reset()
        rdoChooseProperty.Checked = True
        ucrBase.OKEnabled(False) ' this is temporary
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub grpProperty_CheckedChanged(sender As Object, e As EventArgs) Handles rdoChooseProperty.CheckedChanged, rdoDefineNewProperty.CheckedChanged
        ChooseOrDefineProperty()
    End Sub

    Private Sub ChooseOrDefineProperty()
        If rdoDefineNewProperty.Checked Then
            ucrReceiverChooseProperty.Visible = False
            ucrInputDefineProperty.Visible = True
            ucrReceiverChooseProperty.ResetText()
            ucrReceiverChooseColumns.Focus()
        ElseIf rdoChooseProperty.Checked Then
            ucrReceiverChooseProperty.Visible = True
            ucrInputDefineProperty.Visible = False
        End If
        SetPropertyArgument()
    End Sub

    Private Sub SetPropertyArgument()
        If rdoChooseProperty.Checked Then
            If ucrReceiverChooseProperty.IsEmpty Then
                ucrBase.clsRsyntax.RemoveParameter("property")
            Else
                ucrBase.clsRsyntax.AddParameter("property", ucrReceiverChooseProperty.GetVariableNames)
            End If
        ElseIf rdoDefineNewProperty.Checked Then
            If ucrInputDefineProperty.IsEmpty Then
                ucrBase.clsRsyntax.RemoveParameter("property")
            Else
                ucrBase.clsRsyntax.AddParameter("property", Chr(34) & ucrInputDefineProperty.GetText & Chr(34))
            End If
        Else
            ucrBase.clsRsyntax.RemoveParameter("property")
        End If
        GetCurrMetaVal()
    End Sub

    Private Sub GetCurrMetaVal()
        Dim expCurrMetadataValues As SymbolicExpression
        Dim strCurrMetadataValues As CharacterVector
        Dim bSetCurrentValue As Boolean = False
        Dim bListSet As Boolean = False
        Dim strCurrentColumnValue As String = ""

        If rdoChooseProperty.Checked AndAlso Not ucrReceiverChooseProperty.IsEmpty Then
            clsGetVarMetadata.AddParameter("property", ucrReceiverChooseProperty.GetVariableNames())
            clsGetVarMetadata.AddParameter("column", ucrReceiverChooseColumns.GetVariableNames)
            expCurrMetadataValues = frmMain.clsRLink.RunInternalScriptGetValue(clsGetVarMetadata.ToScript(), bSilent:=True)
            If expCurrMetadataValues IsNot Nothing Then
                strCurrMetadataValues = expCurrMetadataValues.AsCharacter
                If strCurrMetadataValues.Distinct.Count = 1 Then
                    ucrCurrentValue.SetName(strCurrMetadataValues(0))
                    bSetCurrentValue = True
                End If
            End If
            clsGetVarMetadata.RemoveParameterByName("column")
            expCurrMetadataValues = frmMain.clsRLink.RunInternalScriptGetValue(clsGetVarMetadata.ToScript(), bSilent:=True)
            If expCurrMetadataValues IsNot Nothing Then
                strCurrMetadataValues = expCurrMetadataValues.AsCharacter
                clsLayerParam.lstParameterStrings = strCurrMetadataValues.Distinct.ToArray
                bListSet = True
            End If
            'To be updated, not correct
            ucrNewValue.SetControls(Nothing, clsLayerParam)
        End If
        If Not bSetCurrentValue Then
            ucrCurrentValue.SetName("")
        End If
        If Not bListSet Then
            clsLayerParam.lstParameterStrings = Nothing
        End If
    End Sub

    Private Sub ucrSelectByMetadata_DataFrameChanged() Handles ucrSelectByMetadata.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectByMetadata.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        clsGetVarMetadata.AddParameter("data_name", Chr(34) & ucrSelectByMetadata.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub ucrReceiverChooseColumns_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverChooseColumns.SelectionChanged
        If Not ucrReceiverChooseColumns.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("column", ucrReceiverChooseColumns.GetVariableNames)
        Else
            ucrBase.clsRsyntax.RemoveParameter("column")
        End If
        GetCurrMetaVal()
    End Sub

    Private Sub ucrInputDefineProperty_NameChanged() Handles ucrInputDefineProperty.NameChanged
        SetPropertyArgument()
    End Sub

    Private Sub ucrReceiverNewValue_TextChanged(sender As Object, e As EventArgs) Handles ucrNewValue.TextChanged
        If rdoDefineNewProperty.Checked Then
            ucrBase.clsRsyntax.AddParameter("new_val", Chr(34) & ucrNewValue.ucrInputTextValue.GetText & Chr(34))
        ElseIf rdoChooseProperty.Checked AndAlso Not ucrCurrentValue.IsEmpty Then
            ucrBase.clsRsyntax.RemoveParameter("new_val")
        End If
    End Sub

    Private Sub ucrReceiverChooseProperty_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverChooseProperty.SelectionChanged
        SetPropertyArgument()
    End Sub

    Private Sub ucrNewValue_ControlContentsChanged() Handles ucrNewValue.ControlContentsChanged
        If ucrNewValue.Text <> "" Then
            ucrBase.clsRsyntax.AddParameter("new_val", Chr(34) & ucrNewValue.ctrActive.Text & Chr(34))
        Else
            ucrBase.clsRsyntax.RemoveParameter("new_val")
        End If
    End Sub
End Class