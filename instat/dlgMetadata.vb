'Instat-R
'Copyright (C) 2015
'This program is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'You should have received a copy of the GNU General Public License k
'along with this program.  If not, see <http://www.gnu.org/licenses/>.
'
Imports instat.Translations
Imports RDotNet
Public Class dlgMetadata
    Public clsgetVarMetadata As New RFunction
    Public bFirstLoad As Boolean = True
    Private Sub dlgMetadata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            InitialiseDialog()
            setDefaults()
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
        ucrReceiverChooseProperty.Selector = ucrSelectByMetadata
        ucrReceiverChooseColumns.Selector = ucrSelectByMetadata
        ucrReceiverChooseProperty.SetMeAsReceiver()
        ucrBase.iHelpTopicID = 391
        ucrReceiverChooseColumns.SetItemType("column")
        ucrReceiverChooseProperty.SetItemType("metadata")
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$append_to_variables_metadata")
        clsgetVarMetadata.SetRCommand("get_variables_metadata")

    End Sub

    Private Sub setDefaults()
        ucrSelectByMetadata.Reset()
        ucrCurrentValue.IsReadOnly = True
        rdoChooseProperty.Checked = True
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        setDefaults()
        TestOKEnabled()
    End Sub

    Private Sub grpProperty_CheckedChanged(sender As Object, e As EventArgs) Handles rdoChooseProperty.CheckedChanged, rdoDefineNewProperty.CheckedChanged
        DefineProperty()
    End Sub

    Private Sub DefineProperty()
        If rdoDefineNewProperty.Checked Then
            ucrReceiverChooseProperty.Visible = False
            ucrInputDefineProperty.Visible = True
            ucrReceiverChooseProperty.ResetText()
            ucrReceiverChooseColumns.Focus()
            ucrBase.clsRsyntax.AddParameter("property", Chr(34) & ucrInputDefineProperty.GetText & Chr(34))

        ElseIf rdoChooseProperty.Checked Then
            ucrReceiverChooseProperty.Visible = True
            ucrInputDefineProperty.Visible = False
            ucrInputDefineProperty.Reset()
            clsgetVarMetadata.SetRCommand("get_variables_metadata")
            ucrBase.clsRsyntax.AddParameter("property", ucrReceiverChooseProperty.GetVariableNames)
        Else
            ucrBase.clsRsyntax.RemoveParameter("property")
        End If
    End Sub

    Private Sub getCurrVals()
        Dim getMetTemp As SymbolicExpression
        getMetTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsgetVarMetadata.ToScript())
    End Sub

    Private Sub ucrSelectByMetadata_DataFrameChanged() Handles ucrSelectByMetadata.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectByMetadata.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub ucrReceiverChooseColumns_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverChooseColumns.SelectionChanged, ucrReceiverChooseProperty.SelectionChanged

        If Not ucrReceiverChooseProperty.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("property", ucrReceiverChooseProperty.GetVariableNames)
        ElseIf Not ucrReceiverChooseColumns.IsEmpty
            ucrBase.clsRsyntax.AddParameter("col_names", ucrReceiverChooseColumns.GetVariableNames)
        End If

    End Sub

    Private Sub ucrInputDefineProperty_NameChanged() Handles ucrInputDefineProperty.NameChanged
        If Not ucrInputDefineProperty.IsEmpty Then
            DefineProperty()
        End If
    End Sub

    Private Sub ucrReceiverNewValue_TextChanged(sender As Object, e As EventArgs) Handles ucrReceiverNewValue.TextChanged
        If rdoDefineNewProperty.Checked Then
            ucrBase.clsRsyntax.AddParameter("new_val", Chr(34) & ucrReceiverNewValue.ucrInputTextValue.GetText & Chr(34))

        ElseIf rdoChooseProperty.Checked AndAlso Not ucrCurrentValue.IsEmpty


        End If
    End Sub
End Class