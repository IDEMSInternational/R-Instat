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
        ucrDataSelectorFrom.SetParameter(New RParameter("from_data_frame", 0))
        ucrDataSelectorFrom.SetParameterIsString()
        ucrDataSelectorTo.SetParameter(New RParameter("to_data_frame", 0))
        ucrDataSelectorTo.SetParameterIsString()
        ucrInputLinkName.SetParameter(New RParameter("link_name", 0))
        ucrInputSelectedKey.SetParameter(New RParameter("type", 3))
        ucrInputSelectedKey.AddQuotesIfUnrecognised = True

        lvwLinkViewBox.Columns.Add("Name", 80, HorizontalAlignment.Left)
        lvwLinkViewBox.Columns.Add("Columns", 160, HorizontalAlignment.Left)

    End Sub

    Private Sub SetDefaults()
        clsAddLink = New RFunction
        ucrDataSelectorFrom.Reset()
        ucrDataSelectorTo.Reset()
        UpdateKeys()
        clsAddLink.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_link")
        ucrBase.clsRsyntax.SetBaseRFunction(clsAddLink)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ' ucrDataSelectorTo.AddAdditionalCodeParameterPair(clsGetKeys, New RParameter("data_name", 0), iAdditionalPairNo:=1)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()
    End Sub

    Private Sub ucrBaseReplace_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrDataSelectorTo_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrDataSelectorTo.ControlValueChanged
        UpdateKeys()
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

        lblKeys.Text = ucrDataSelectorTo.cboAvailableDataFrames.SelectedItem & " keys:"
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
                    lviTemp.ForeColor = Color.Green
                Else
                    lviTemp.ForeColor = Color.Red
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
    End Sub
End Class