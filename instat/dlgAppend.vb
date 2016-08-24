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
Public Class dlgAppend
    Public bFirstLoad As Boolean = True
    Private Sub dlgAppend_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub InitialiseDialog()
        ucrReceiverAppendDataframe.Selector = ucrSelectorDataframes
        ucrReceiverAppendDataframe.SetMeAsReceiver()
        ucrBase.clsRsyntax.SetFunction("bind_rows")
        ucrReceiverAppendDataframe.SetItemType("dataframe")
        ucrInputIDColName.SetValidationTypeAsRVariable()

    End Sub

    Private Sub TestOKEnabled()
        If ucrReceiverAppendDataframe.IsEmpty = False Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
        ucrSelectorDataframes.Reset()
        ucrInputIDColName.SetName("ID_Col")
        ucrInputNewDataframeName.ResetText()
        ucrInputIDColName.ResetText()
        chkIncludeIDColumn.Checked = False
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverAppendDataframe_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverAppendDataframe.SelectionChanged
        If ucrReceiverAppendDataframe.IsEmpty = False Then
            ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverAppendDataframe.GetVariables)
        Else
            ucrBase.clsRsyntax.RemoveParameter("x")
        End If
        TestOKEnabled()
    End Sub

    Private Sub chkIncludeIDColumn_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncludeIDColumn.CheckedChanged
        includeIDColumn()
    End Sub

    Private Sub ucrInputIDColName_NameChanged() Handles ucrInputIDColName.NameChanged
        includeIDColumn()
    End Sub

    Private Sub includeIDColumn()
        If chkIncludeIDColumn.Checked Then
            ucrBase.clsRsyntax.AddParameter(".id", Chr(34) & ucrInputIDColName.GetText & Chr(34))
        Else
            ucrBase.clsRsyntax.RemoveParameter(".id")
        End If
    End Sub

    Private Sub ucrInputNewDataframeName_NameChanged() Handles ucrInputNewDataframeName.NameChanged
        ucrBase.clsRsyntax.SetAssignTo(ucrInputNewDataframeName.GetText(), strTempDataframe:=ucrInputNewDataframeName.GetText())
    End Sub
End Class