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

Imports instat.Translations

Public Class ucrButtonsSubdialogue
    Public Event ClickReturn(sender As Object, e As EventArgs)
    Public iHelpTopicID As Integer
    Private strCurrLang As String

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.ParentForm.Close()
    End Sub

    Private Sub cmdReturn_Click(sender As Object, e As EventArgs) Handles cmdReturn.Click
        Enabled = False
        RaiseEvent ClickReturn(sender, e)
        Enabled = True
        Me.ParentForm.Close()
    End Sub

    Private Sub HelpContent()
        ' (1) Use HelpNDoc's Help Context number. Not dependent on HelpNDoc.
        If iHelpTopicID > 0 Then
            Help.ShowHelp(Me.Parent, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, iHelpTopicID.ToString())
        Else
            Help.ShowHelp(Me.Parent, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TableOfContents)
        End If
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        HelpContent()
    End Sub

    Private Sub cmdLanguage_Click(sender As Object, e As EventArgs) Handles cmdLanguage.Click

        If strCurrLang <> "en-GB" Then
            strCurrLang = "en-GB"
        Else
            strCurrLang = frmMain.clsInstatOptions.strLanguageCultureCode
        End If

        Dim strConfiguredLanguage As String = frmMain.clsInstatOptions.strLanguageCultureCode
        frmMain.clsInstatOptions.strLanguageCultureCode = strCurrLang
        autoTranslate(Me.ParentForm)
        frmMain.clsInstatOptions.strLanguageCultureCode = strConfiguredLanguage

        If cmdLanguage.FlatStyle = FlatStyle.Popup Then
            cmdLanguage.FlatStyle = FlatStyle.Flat
        Else
            cmdLanguage.FlatStyle = FlatStyle.Popup
        End If
    End Sub

    Private Sub ucrButtonsSubdialogue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmMain.clsInstatOptions IsNot Nothing Then
            If frmMain.clsInstatOptions.strLanguageCultureCode <> "en-GB" Then
                cmdHelp.Width = cmdReturn.Width / 2
                cmdLanguage.Visible = True
            Else
                cmdHelp.Width = cmdReturn.Width
                cmdLanguage.Visible = False
            End If
            strCurrLang = frmMain.clsInstatOptions.strLanguageCultureCode
        End If
    End Sub
End Class
