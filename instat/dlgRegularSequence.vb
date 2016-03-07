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
Public Class dlgRegularSequence
    Dim bIsExtended As Boolean = False
    Public bFirstLoad As Boolean = True
    Private Sub dlgRegularSequence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("seq")
        autoTranslate(Me)
        ucrBase.iHelpTopicID = 30
        frmMain.clsRLink.SetOutput(txtGetPreview)
        'ucrSelectDataFrame.SetColumnList(ucrColName)
        ucrNewColumnNameSelectorRegularSequence.SetDataFrameSelector(ucrSelectDataFrame)
        ucrNewColumnNameSelectorRegularSequence.SetPrefix("Sequence")
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnNameSelectorRegularSequence.cboColumnName.Text, strTempDataframe:=ucrSelectDataFrame.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnNameSelectorRegularSequence.cboColumnName.Text)

        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If

        TestOKEnabled()
    End Sub

    Private Sub SetDefaults()
        dtpSelectorA.Visible = False
        dtpSelectorB.Visible = False

    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        If nudFrom.Value <> "" And nudTo.Value <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)

        End If
    End Sub


    Private Sub txtFrom_Leave(sender As Object, e As EventArgs)

        'If IsNumeric(txtFrom.Text) = True Or txtFrom.Text = "" Then
        '    ucrBase.clsRsyntax.AddParameter("from", txtFrom.Text)

        'ElseIf IsNumeric(txtFrom.Text) = False Then
        '    MsgBox("Enter numeric value", vbOKOnly)
        '    txtFrom.Focus()

        'End If



    End Sub
    Private Sub txtRepeatValues_Leave(sender As Object, e As EventArgs)

        'If IsNumeric(txtRepeatValues.Text) = True Or nudRepeatValues.Text = "" Then
        '    ucrBase.clsRsyntax.AddParameter("from", txtRepeatValues.Text)

        'ElseIf IsNumeric(txtRepeatValues.Text) = False Then
        '    MsgBox("Enter numeric value", vbOKOnly)
        '    txtRepeatValues.Focus()

        'End If



    End Sub
    Private Sub txtTo_Leave(sender As Object, e As EventArgs)
        'If IsNumeric(txtFrom.Text) = True Or txtTo.Text = "" Then
        '    ucrBase.clsRsyntax.AddParameter("from", txtTo.Text)

        'ElseIf IsNumeric(txtTo.Text) = False Then
        '    MsgBox("Enter numeric value", vbOKOnly)
        '    txtTo.Focus()

        'End If

    End Sub

    Private Sub rdoNumeric_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNumeric.Click
        If rdoNumeric.Checked = True Then
            dtpSelectorA.Visible = False
            dtpSelectorB.Visible = False
            chkDefineAsFactor.Visible = True

        End If
    End Sub


    Private Sub dtpSelectorA_Leave(sender As Object, e As EventArgs)
        ucrBase.clsRsyntax.AddParameter("from", "as.Date('" & Format(dtpSelectorA.Value, "yyyy/MM/dd") & "')")
    End Sub
    Private Sub dtpSelectorB_Leave(sender As Object, e As EventArgs)
        ucrBase.clsRsyntax.AddParameter("to", "as.Date('" & Format(dtpSelectorB.Value, "yyyy/MM/dd") & "')")
    End Sub
    Private Sub cboInStepsOf_SelectedIndexChanged(sender As Object, e As EventArgs)
        ucrBase.clsRsyntax.AddParameter("by", "'" & nudInstepsOf.Value.ToString() & "'")
    End Sub
    Private Sub txtRepeatValues_TextChanged(sender As Object, e As EventArgs)
        ucrBase.clsRsyntax.AddParameter("length.out", nudRepeatValues.Text)
    End Sub
    Private Sub ucrSelectDataFrame_LostFocus(sender As Object, e As EventArgs) Handles ucrSelectDataFrame.LostFocus
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnNameSelectorRegularSequence.cboColumnName.Text, strTempDataframe:=ucrSelectDataFrame.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnNameSelectorRegularSequence.cboColumnName.Text)
    End Sub

    Private Sub ucrColName_LostFocus(sender As Object, e As EventArgs) Handles ucrNewColumnNameSelectorRegularSequence.LostFocus
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnNameSelectorRegularSequence.cboColumnName.Text, strTempDataframe:=ucrSelectDataFrame.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnNameSelectorRegularSequence.cboColumnName.Text)
    End Sub


    Private Sub cboInStepsOf_TextChanged(sender As Object, e As EventArgs)
        ucrBase.clsRsyntax.AddParameter("by", nudInstepsOf.Text)
    End Sub

    Private Sub cmdRefreshPreview_Click(sender As Object, e As EventArgs) Handles cmdRefreshPreview.Click
        frmMain.clsRLink.RunScript(ucrBase.clsRsyntax.GetScript(), ucrBase.clsRsyntax.iCallType)
        txtGetPreview.Refresh()
    End Sub

End Class