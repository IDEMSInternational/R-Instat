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
    Private Sub dlgRegularSequence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpSequence2.Hide()
        grpRepeatSingle.Hide()
        ucrBase.clsRsyntax.SetFunction("seq")
        autoTranslate(Me)
        ucrSelectDataFrame.SetColumnList(ucrColName)
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrColName.cboColumnName.Text, strTempDataframe:=ucrSelectDataFrame.cboAvailableDataFrames.Text, strTempColumn:=ucrColName.cboColumnName.Text)
    End Sub

    Private Sub rdoSingleValue_Click(sender As Object, e As EventArgs) Handles rdoSingleValue.Click
        grpSequence.Hide()
        grpSequence2.Hide()
        grpRepeatSingle.Visible = True
    End Sub

    Private Sub rdDates_Click(sender As Object, e As EventArgs) Handles rdoDates.Click
        grpSequence.Hide()
        grpRepeatSingle.Hide()
        grpSequence2.Visible = True
    End Sub

    Private Sub rdSequence_Click(sender As Object, e As EventArgs) Handles rdoSequence.Click
        grpRepeatSingle.Hide()
        grpSequence2.Hide()
        grpSequence.Visible = True
    End Sub

    Private Sub txtFrom_Leave(sender As Object, e As EventArgs) Handles txtFrom.Leave
        ucrBase.clsRsyntax.AddParameter("from", txtFrom.Text)
    End Sub

    Private Sub txtTo_TextChanged(sender As Object, e As EventArgs) Handles txtTo.Leave
        ucrBase.clsRsyntax.AddParameter("to", txtTo.Text)
    End Sub

    Private Sub txtSteps_TextChanged(sender As Object, e As EventArgs) Handles txtSteps.Leave
        ucrBase.clsRsyntax.AddParameter("by", txtSteps.Text)
    End Sub

    Private Sub dtSelectorA_Leave(sender As Object, e As EventArgs) Handles dtSelectorA.Leave
        ucrBase.clsRsyntax.AddParameter("from", "as.Date('" & Format(dtSelectorA.Value, "yyyy/MM/dd") & "')")
    End Sub

    Private Sub dtSelectorB_Leave(sender As Object, e As EventArgs) Handles dtSelectorB.Leave
        ucrBase.clsRsyntax.AddParameter("to", "as.Date('" & Format(dtSelectorB.Value, "yyyy/MM/dd") & "')")
    End Sub

    Private Sub cboBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBy.Leave
        ucrBase.clsRsyntax.AddParameter("by", "'" & cboBy.SelectedItem.ToString() & "'")
    End Sub

    Private Sub txtValue_TextChanged(sender As Object, e As EventArgs) Handles txtValue.Leave
        Dim funct() As String = {"from", "to"}
        For Each Val As String In funct
            ucrBase.clsRsyntax.AddParameter(Val, txtValue.Text)
        Next
    End Sub

    Private Sub txtRepeatTimes_TextChanged(sender As Object, e As EventArgs) Handles txtRepeatTimes.Leave
        ucrBase.clsRsyntax.AddParameter("length.out", txtRepeatTimes.Text)
    End Sub

    Private Sub ucrSelectDataFrame_LostFocus(sender As Object, e As EventArgs) Handles ucrSelectDataFrame.LostFocus
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrColName.cboColumnName.Text, strTempDataframe:=ucrSelectDataFrame.cboAvailableDataFrames.Text, strTempColumn:=ucrColName.cboColumnName.Text)
    End Sub

    Private Sub ucrColName_LostFocus(sender As Object, e As EventArgs) Handles ucrColName.LostFocus
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrColName.cboColumnName.Text, strTempDataframe:=ucrSelectDataFrame.cboAvailableDataFrames.Text, strTempColumn:=ucrColName.cboColumnName.Text)
    End Sub
End Class