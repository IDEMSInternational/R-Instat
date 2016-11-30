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
Public Class dlgView
    Public bFirstLoad As Boolean = True

    Private Sub dlgView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.iCallType = 2

        If bFirstLoad Then
            SetDefaults()
            InitialiseDialog()
            bFirstLoad = False
        End If
        'Checks if Ok can be enabled.
        TestOKEnabled()
    End Sub

    Private Sub SetDefaults()
        If nudNumberRows.Maximum >= 6 Then
            nudNumberRows.Value = 6
        Else
            nudNumberRows.Value = nudNumberRows.Maximum
        End If
        ucrSelctorForView.Reset()
        ucrSelctorForView.Focus()
        rdoTop.Checked = True
        grpDisplayFrom.ResetText()
        ' By default the dialogue is in preview mode rather than View mode. See SetCommands() for details.
        rdoViewPreview.Checked = True
        rdoViewDataFrame.Checked = False
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverView.Selector = ucrSelctorForView
        ucrReceiverView.SetMeAsReceiver()
        ucrBase.iHelpTopicID = 32

    End Sub

    Private Sub TestOKEnabled()
        'OK is enabled 1st when the View preview radio button is checked and the receiver and  up and down rows are non-empty 
        'ALSO, when the radio button View Data Frame is checked, the OK should be enabled regardless of the receiver being empty or non-empty since it is not connected to it at all(It striggers the View command to pick the current dataframe as its argument only).
        If ((Not (ucrReceiverView.IsEmpty) AndAlso nudNumberRows.Text <> "") AndAlso rdoViewPreview.Checked) OrElse rdoViewDataFrame.Checked Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub grpDisplayFrom_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBottom.CheckedChanged, rdoTop.CheckedChanged
        SetCommands()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverView_SelctionChanged() Handles ucrReceiverView.SelectionChanged
        SetCommands()
        TestOKEnabled()
    End Sub

    Private Sub nudNumberRows_TextChanged(sender As Object, e As EventArgs) Handles nudNumberRows.TextChanged
        SetCommands()
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrSelctorForView_DataFrameChanged() Handles ucrSelctorForView.DataFrameChanged
        nudNumberRows.Maximum = ucrSelctorForView.ucrAvailableDataFrames.iDataFrameLength
        TestOKEnabled()
    End Sub

    Private Sub rdoViewPreview_CheckedChanged(sender As Object, e As EventArgs) Handles rdoViewPreview.CheckedChanged, rdoViewDataFrame.CheckedChanged
        SetCommands()
        TestOKEnabled()
    End Sub

    Private Sub SetCommands()
        'Adding the View command and its parameter while ensuring the the "n" parameter of the tail nd head are excluded as its parameters
        If rdoViewDataFrame.Checked Then
            ucrBase.clsRsyntax.RemoveParameter("n")
            ucrBase.clsRsyntax.SetFunction("View")
            ucrBase.clsRsyntax.AddParameter("x", ucrSelctorForView.strCurrentDataFrame)
        ElseIf rdoViewPreview.Checked Then
            'Adding commands and parameter for head and tail 
            If Not ucrReceiverView.IsEmpty Then
                ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverView.GetVariables())
                If rdoTop.Checked Then
                    ucrBase.clsRsyntax.SetFunction("head")
                Else
                    ucrBase.clsRsyntax.SetFunction("tail")
                End If
                If Not nudNumberRows.Text = "" Then
                    ucrBase.clsRsyntax.AddParameter("n", nudNumberRows.Value)
                End If
            End If
        End If
    End Sub

End Class