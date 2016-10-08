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
Public Class dlgName
    Dim bFirstLoad As Boolean = True
    Dim bUseSelectedColumn As Boolean = False
    Dim strSelectedColumn As String = ""
    Dim strSelectedDataFrame As String = ""

    Private Sub dlgName_Load(sender As Object, e As EventArgs) Handles Me.Load
        ucrBase.iHelpTopicID = 33
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        If bUseSelectedColumn Then
            SetDefaultColumn()
        End If
        TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()
        ucrReceiverName.txtReceiverSingle.Clear()
        ucrInputNewName.txtInput.Clear()
    End Sub

    Private Sub TestOKEnabled()
        If ((Not ucrReceiverName.IsEmpty()) And (Not ucrInputNewName.IsEmpty())) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverName.Selector = ucrSelectVariables
        ucrReceiverName.SetMeAsReceiver()
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$rename_column_in_data")
        ucrInputNewName.SetValidationTypeAsRVariable()
    End Sub

    Public Sub SetDefaults()
        ucrSelectVariables.Reset()
        ucrInputNewName.ResetText()
    End Sub

    Public Sub SetCurrentColumn(strColumn As String, strDataFrame As String)
        strSelectedColumn = strColumn
        strSelectedDataFrame = strDataFrame
        bUseSelectedColumn = True
    End Sub

    Private Sub SetDefaultColumn()
        ucrSelectVariables.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem = strSelectedDataFrame
        ucrReceiverName.Add(strSelectedColumn, strSelectedDataFrame)
        bUseSelectedColumn = False
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverName_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverName.SelectionChanged
        If Not ucrReceiverName.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("column_name", ucrReceiverName.GetVariableNames)
            ucrInputNewName.SetName(ucrReceiverName.GetVariableNames(bWithQuotes:=False))
        Else
            ucrBase.clsRsyntax.RemoveParameter("column_name")
        End If
        TestOKEnabled()
    End Sub

    Private Sub UcrInputNewName_NameChanged() Handles ucrInputNewName.NameChanged
        If Not ucrInputNewName.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("new_val", Chr(34) & ucrInputNewName.GetText & Chr(34))
        Else
            ucrBase.clsRsyntax.RemoveParameter("new_val")
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectVariables_DataFrameChanged() Handles ucrSelectVariables.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectVariables.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub
End Class
