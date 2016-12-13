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
    Public clsHead, clsTail As New RFunction
    Public bFirstLoad As Boolean = True

    Private Sub dlgView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        'Checks if Ok can be enabled.
        TestOKEnabled()
        autoTranslate(Me)
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
        ' By default:Display of the dataset is on a separate window. See SetCommands() for details.
        rdoDispSepOutputWindow.Checked = True
        rdoDispOutputWindow.Checked = False
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverView.Selector = ucrSelctorForView
        ucrReceiverView.SetMeAsReceiver()
        ucrBase.iHelpTopicID = 32
        clsHead.SetRCommand("head")
        clsTail.SetRCommand("tail")
    End Sub

    Private Sub TestOKEnabled()
        'OK is enabled when the ucrReceiverView and nudNumberRows are both non-empty in both cases of Window display
        If (Not (ucrReceiverView.IsEmpty) AndAlso nudNumberRows.Text <> "") Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If

    End Sub

    Private Sub grpDisplayFrom_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBottom.CheckedChanged, rdoTop.CheckedChanged
        SetCommands()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverView_SelctionChanged(ender As Object, e As EventArgs) Handles ucrReceiverView.SelectionChanged
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

    Private Sub grpDisplay_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDispOutputWindow.CheckedChanged, rdoDispSepOutputWindow.CheckedChanged
        SetCommands()
        TestOKEnabled()
    End Sub

    Private Sub SetCommands()
        'Setting the head and tail functions as parameters of View Function
        If rdoDispSepOutputWindow.Checked Then
            ucrBase.clsRsyntax.SetFunction("View")
            ucrBase.clsRsyntax.RemoveParameter("n")
            If rdoBottom.Checked Then
                clsTail.AddParameter("x", clsRFunctionParameter:=ucrReceiverView.GetVariables)
                clsTail.AddParameter("n", nudNumberRows.Value)
                ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=clsTail, bIncludeArgumentName:=False)
            ElseIf rdoTop.Checked Then
                clsHead.AddParameter("x", clsRFunctionParameter:=ucrReceiverView.GetVariables)
                clsHead.AddParameter("n", nudNumberRows.Value)
                ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=clsHead, bIncludeArgumentName:=False)
            End If
            ucrBase.clsRsyntax.AddParameter("title", Chr(34) & ucrSelctorForView.strCurrentDataFrame & Chr(34))

        ElseIf rdoDispOutputWindow.Checked Then
            'remove the title parameter of the View command then setting head and tail functions for previewing the dataset in the output window.
            ucrBase.clsRsyntax.iCallType = 2
            ucrBase.clsRsyntax.RemoveParameter("title")
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