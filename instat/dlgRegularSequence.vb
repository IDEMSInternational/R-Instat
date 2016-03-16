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

        autoTranslate(Me)



        If bFirstLoad Then
            InitializeDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub InitializeDialog()
        ucrBase.clsRsyntax.SetFunction("seq")
        ucrBase.iHelpTopicID = 30
        UcrDataFrameLengthForRegularSequence.SetDataFrameSelector(ucrSelectDataFrameRegularSequence)
        UcrInputCboRegularSequence.SetPrefix("Regular")
        UcrInputCboRegularSequence.SetItemsTypeAsColumns()
        UcrInputCboRegularSequence.SetDefaultTypeAsColumn()
        UcrInputCboRegularSequence.SetDataFrameSelector(ucrSelectDataFrameRegularSequence)
    End Sub

    Private Sub SetDefaults()
        rdoNumeric.Checked = True
        rdoDates.Checked = False
        ucrSelectDataFrameRegularSequence.Reset()
        ucrSelectDataFrameRegularSequence.Focus()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()

    End Sub

    Private Sub TestOKEnabled()
        If rdoNumeric.Checked = True Then
            If nudFrom.Text <> "" And nudTo.Text <> "" Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoDates.Checked = True Then

            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    'Private Sub cmdRefreshPreview_Click(sender As Object, e As EventArgs) Handles cmdRefreshPreview.Click
    '    frmMain.clsRLink.RunScript(ucrBase.clsRsyntax.clsBaseFunction.ToScript(), 2)
    '    txtGetPreview.Refresh()
    'End Sub

    Private Sub grpSequenceType_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDates.CheckedChanged, rdoNumeric.CheckedChanged
        If rdoNumeric.Checked Then
            nudFrom.Visible = True
            nudTo.Visible = True
            dtpSelectorA.Visible = False
            dtpSelectorB.Visible = False
            nudRepeatValues.Enabled = False
        Else
            dtpSelectorA.Visible = True
            dtpSelectorB.Visible = True
            nudFrom.Visible = False
            nudTo.Visible = False
        End If
        TestOKEnabled()
    End Sub

    Private Sub nudInstepsOf_ValueChanged(sender As Object, e As EventArgs) Handles nudInstepsOf.ValueChanged
        ucrBase.clsRsyntax.AddParameter("by", nudInstepsOf.Value)
    End Sub

    Private Sub nudRepeatValues_ValueChanged(sender As Object, e As EventArgs) Handles nudRepeatValues.ValueChanged
        If rdoDates.Checked Then
            ucrBase.clsRsyntax.AddParameter("length.out", "NULL")
        Else
            ucrBase.clsRsyntax.AddParameter("length.out", nudRepeatValues.Value)
        End If

    End Sub

    Private Sub nudFrom_ValueChanged(sender As Object, e As EventArgs) Handles nudFrom.ValueChanged
        ucrBase.clsRsyntax.AddParameter("from", nudFrom.Value)
    End Sub

    Private Sub nudTo_ValueChanged(sender As Object, e As EventArgs) Handles nudTo.ValueChanged
        ucrBase.clsRsyntax.AddParameter("to", nudTo.Value)
    End Sub

    Private Sub dtpSelectorA_ValueChanged(sender As Object, e As EventArgs) Handles dtpSelectorA.ValueChanged
        ucrBase.clsRsyntax.AddParameter("from", "as.Date('" & Format(dtpSelectorA.Value, "yyyy/MM/dd") & "')")
    End Sub

    Private Sub dtpSelectorB_ValueChanged(sender As Object, e As EventArgs) Handles dtpSelectorB.ValueChanged
        ucrBase.clsRsyntax.AddParameter("to", "as.Date('" & Format(dtpSelectorB.Value, "yyyy/MM/dd") & "')")
    End Sub

    Private Sub UcrInputCboRegularSequence_NameChanged() Handles UcrInputCboRegularSequence.NameChanged
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=UcrInputCboRegularSequence.GetText, strTempDataframe:=ucrSelectDataFrameRegularSequence.cboAvailableDataFrames.Text, strTempColumn:=UcrInputCboRegularSequence.GetText)
    End Sub
End Class