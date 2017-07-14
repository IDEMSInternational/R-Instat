' R- Instat
' Copyright (C) 2015-2017
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

Imports instat
Imports instat.Translations
Imports RDotNet
Public Class dlgAddLink
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsAddLink As RFunction

    Private Sub dlgAddLink_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 506
        cmdSpecifyLink.Enabled = False ' temporarily disabled

        ucrDataSelectorFrom.SetParameter(New RParameter("from_data_frame", 0))
        ucrDataSelectorFrom.SetParameterIsString()

        ucrDataSelectorTo.SetParameter(New RParameter("to_data_frame", 1))
        ucrDataSelectorTo.SetParameterIsString()

        ucrInputLinkName.SetParameter(New RParameter("link_name", 4))
        lvwLinkViewBox.Columns.Add("Name", 80, HorizontalAlignment.Left)
        lvwLinkViewBox.Columns.Add("Columns", 150, HorizontalAlignment.Left)
        ucrInputSelectedKey.IsReadOnly = True
    End Sub

    Private Sub SetDefaults()
        clsAddLink = New RFunction

        ucrDataSelectorFrom.Reset()
        ucrDataSelectorTo.Reset()
        ucrInputLinkName.SetName("")

        UpdateKeys()

        clsAddLink.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_link")
        clsAddLink.AddParameter("type", Chr(34) & "keyed_link" & Chr(34), iPosition:=3)

        ucrBase.clsRsyntax.SetBaseRFunction(clsAddLink)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If ucrDataSelectorFrom.cboAvailableDataFrames.Text <> "" AndAlso ucrDataSelectorTo.cboAvailableDataFrames.Text <> "" AndAlso Not ucrInputLinkName.IsEmpty AndAlso Not ucrInputSelectedKey.IsEmpty AndAlso IsSelectionValidKey() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBaseReplace_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()
        UpdateKeys() ' currently I may open the dialog, then realise I haven't set my keys, make my key, reopen this dlg and my key doesn't show up until I reset it.
    End Sub

    Public Sub UpdateKeys()
        Dim clsColumnNames As New RFunction
        Dim lstKeys As GenericVector
        Dim chrKeyColumns As CharacterVector
        Dim lviTemp As ListViewItem
        Dim strKeyColumns As String
        Dim bCanAutoLink As Boolean
        Dim strColumnNames As String()
        Dim clsGetKeys As New RFunction

        lvwLinkViewBox.Items.Clear()

        lblKeys.Text = ucrDataSelectorTo.cboAvailableDataFrames.SelectedItem & " Keys:"
        clsGetKeys.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_keys")
        clsGetKeys.AddParameter("data_name", Chr(34) & ucrDataSelectorTo.cboAvailableDataFrames.SelectedItem & Chr(34))
        lstKeys = frmMain.clsRLink.RunInternalScriptGetValue(clsGetKeys.ToScript).AsList

        clsColumnNames.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_names")
        clsColumnNames.AddParameter("data_name", Chr(34) & ucrDataSelectorFrom.cboAvailableDataFrames.SelectedItem & Chr(34))
        strColumnNames = frmMain.clsRLink.RunInternalScriptGetValue(clsColumnNames.ToScript).AsCharacter().ToArray

        For i = 0 To lstKeys.Count - 1
            chrKeyColumns = lstKeys(i).AsCharacter
            strKeyColumns = String.Join(", ", chrKeyColumns.ToArray)
            If chrKeyColumns IsNot Nothing Then
                lviTemp = New ListViewItem({lstKeys.Names(i), strKeyColumns})
                clsColumnNames.AddParameter("to_columns", "c(" & strKeyColumns & ")")
                bCanAutoLink = chrKeyColumns.ToArray.All(Function(strCol) strColumnNames.Contains(strCol))
                If bCanAutoLink Then
                    lviTemp.BackColor = Color.LightGreen
                    ucrBase.OKEnabled(True)
                Else
                    lviTemp.BackColor = Color.LightCoral
                    ucrBase.OKEnabled(False)
                End If
                lvwLinkViewBox.Items.Add(lviTemp)
            End If
        Next
    End Sub

    Private Sub lvwLinkViewBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwLinkViewBox.SelectedIndexChanged
        Dim strColNames As String()
        Dim clsPairs As New RFunction

        clsPairs.SetRCommand("c")

        If lvwLinkViewBox.SelectedIndices.Count = 1 Then
            strColNames = lvwLinkViewBox.SelectedItems(0).SubItems(1).Text.Split(",")
            For Each strTemp As String In strColNames
                clsPairs.AddParameter(strTemp.Trim(" "), Chr(34) & strTemp.Trim(" ") & Chr(34))
            Next
            clsAddLink.AddParameter("link_pairs", clsRFunctionParameter:=clsPairs, iPosition:=2)
            ucrInputSelectedKey.SetName(lvwLinkViewBox.SelectedItems(0).SubItems(0).Text)
        Else
            clsAddLink.RemoveParameterByName("link_pairs")
            ucrInputSelectedKey.SetName("")
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrDataSelectorTo_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrDataSelectorTo.ControlValueChanged
        UpdateKeys()
        TestOKEnabled()
    End Sub

    Private Sub ucrDataSelectorFrom_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrDataSelectorFrom.ControlContentsChanged, ucrInputLinkName.ControlContentsChanged, ucrInputSelectedKey.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Function IsSelectionValidKey() As Boolean
        If lvwLinkViewBox.SelectedItems.Count = 1 Then
            Return lvwLinkViewBox.SelectedItems(0).BackColor = Color.LightGreen
        Else
            Return False
        End If
    End Function
End Class