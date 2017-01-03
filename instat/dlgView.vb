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
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Imports instat.Translations
Public Class dlgView
    Public clsHead, clsTail, clsView As New RFunction
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
        ucrSelectorForView.Reset()
        ucrSelectorForView.Focus()
        rdoTop.Checked = True
        rdoDispSepOutputWindow.Checked = True
        ucrSpecifyRows.Checked = True
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverView.Selector = ucrSelectorForView
        ucrReceiverView.SetMeAsReceiver()
        DataFrameLength()
        ucrBase.iHelpTopicID = 32
        clsView.SetRCommand("View")
        ucrSpecifyRows.SetText("Specify Rows")
    End Sub

    Private Sub TestOKEnabled()
        'OK is enabled when the ucrReceiverView and nudNumberRows are both non-empty in both cases of Window display
        If Not ucrReceiverView.IsEmpty Then
            If rdoDispOutputWindow.Checked AndAlso ucrSpecifyRows.Checked AndAlso Not nudNumberRows.Text <> "" Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
            End If
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub grpDisplayFrom_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBottom.CheckedChanged, rdoTop.CheckedChanged
        SetCommands()
    End Sub

    Private Sub ucrReceiverView_SelctionChanged(sender As Object, e As EventArgs) Handles ucrReceiverView.SelectionChanged
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

    Private Sub ucrSelectorForView_DataFrameChanged() Handles ucrSelectorForView.DataFrameChanged
        DataFrameLength()
        clsView.AddParameter("title", Chr(34) & ucrSelectorForView.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
    End Sub

    Private Sub DataFrameLength()
        nudNumberRows.Maximum = ucrSelectorForView.ucrAvailableDataFrames.iDataFrameLength
    End Sub

    Private Sub grpDisplay_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDispOutputWindow.CheckedChanged, rdoDispSepOutputWindow.CheckedChanged
        SetCommands()
        TestOKEnabled()
    End Sub

    Private Sub SetCommands()
        If rdoDispSepOutputWindow.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsView)
            ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverView.GetVariables())
        ElseIf rdoDispOutputWindow.Checked Then
            ucrBase.clsRsyntax.iCallType = 2
            If ucrSpecifyRows.Checked Then
                clsHead.RemoveParameterByName("x")
                clsHead.RemoveParameterByName("n")
                XandNParameters()
            Else
                clsHead.SetRCommand("head")
                clsHead.AddParameter("x", clsRFunctionParameter:=ucrReceiverView.GetVariables())
                clsHead.AddParameter("n", ucrSelectorForView.ucrAvailableDataFrames.iDataFrameLength)
                ucrBase.clsRsyntax.SetBaseRFunction(clsHead)
            End If
        End If
    End Sub

    Private Sub XandNParameters()
        If rdoTop.Checked Then
            clsHead.SetRCommand("head")
            If Not ucrReceiverView.IsEmpty Then
                clsHead.AddParameter("x", clsRFunctionParameter:=ucrReceiverView.GetVariables())
            Else
                clsHead.RemoveParameterByName("x")
            End If
            If Not nudNumberRows.Text = "" Then
                clsHead.AddParameter("n", nudNumberRows.Value)
            Else
                clsHead.RemoveParameterByName("n")
            End If
            ucrBase.clsRsyntax.SetBaseRFunction(clsHead)
        Else
            clsTail.SetRCommand("tail")
            If Not ucrReceiverView.IsEmpty Then
                clsTail.AddParameter("x", clsRFunctionParameter:=ucrReceiverView.GetVariables())
            Else
                clsTail.RemoveParameterByName("x")
            End If
            ucrBase.clsRsyntax.SetBaseRFunction(clsTail)
            If Not nudNumberRows.Text = "" Then
                clsTail.AddParameter("n", nudNumberRows.Value)
            Else
                clsTail.RemoveParameterByName("n")
            End If
        End If
    End Sub

    Private Sub rdoDisplayOptions_CheckedChanged() Handles rdoDispOutputWindow.CheckedChanged, rdoDispSepOutputWindow.CheckedChanged
        SetCommands()
        DisplayOptions()
    End Sub

    Private Sub DisplayOptions()
        If rdoDispOutputWindow.Checked Then
            grpDisplayOptions.Visible = True
        Else
            grpDisplayOptions.Visible = False
        End If
        If ucrSpecifyRows.Checked = False Then
            lblDisplayFrom.Visible = False
            lblNumberofRows.Visible = False
            nudNumberRows.Visible = False
            rdoBottom.Visible = False
            rdoTop.Visible = False
        Else
            lblDisplayFrom.Visible = True
            lblNumberofRows.Visible = True
            nudNumberRows.Visible = True
            rdoBottom.Visible = True
            rdoTop.Visible = True
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrSpecifyRows_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSpecifyRows.ControlContentsChanged
        DisplayOptions()
        SetCommands()
    End Sub
End Class