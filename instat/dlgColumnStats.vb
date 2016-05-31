
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
Public Class dlgColumnStats
    Public bFirstLoad As Boolean = True
    Private Sub dlgColumnStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.iCallType = 2

        If bFirstLoad Then
            SetDefaults()
            InitialiseDialog()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        ucrReceiverMultiple.Selector = ucrAddRemove
        ucrReceiverMultiple.SetMeAsReceiver()
        ucrBase.clsRsyntax.SetFunction("colStats")
        ucrBase.iHelpTopicID = 64
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 64
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrReceiverMultiple_Leave(sender As Object, e As EventArgs) Handles ucrReceiverMultiple.Leave
        Dim objItem As Object
        'TODO fix this
        Dim temp_obj As New Object
        'Dim temp_obj As ListBox.ObjectCollection = ucrReceiverMultiple.lstSelectedVariables.Items
        If ucrReceiverMultiple.lstSelectedVariables.Items.Count > 0 Then
            For Each objItem In temp_obj
                ucrBase.clsRsyntax.AddParameter("data_temp$" & objItem & "", "x")
            Next
        End If


    End Sub


End Class