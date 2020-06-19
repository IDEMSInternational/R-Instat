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
Public Class dlgImportOpenRefine
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsImportFunction As New RFunction

    Private Sub dlgImportOpenRefine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub InitialiseDialog()
        Dim dctInputFormat As New Dictionary(Of String, String)
        ucrBase.iHelpTopicID = 467

        ucrInputProjectName.SetParameter(New RParameter("project.name", 0))
        ucrInputProjectName.SetRDefault("NULL")

        ucrInputProjectID.SetParameter(New RParameter("project.id", 1))
        ucrInputProjectID.AddQuotesIfUnrecognised = False
        ucrInputProjectID.SetRDefault("NULL")

        ucrInputFormat.SetParameter(New RParameter("format", 2))
        dctInputFormat.Add("csv", Chr(34) & "csv" & Chr(34))
        ucrInputFormat.SetItems(dctInputFormat)
        ucrInputFormat.SetRDefault(Chr(34) & "csv" & Chr(34))

        ucrNewDataFrameName.SetSaveTypeAsDataFrame()
        ucrNewDataFrameName.SetLabelText("New Data Frame:")
        ucrNewDataFrameName.SetIsTextBox()
    End Sub

    Private Sub SetDefaults()
        clsImportFunction = New RFunction

        ucrNewDataFrameName.Reset()
        ucrInputProjectName.SetName("")

        clsImportFunction.SetPackageName("rrefine")
        clsImportFunction.SetRCommand("refine_export")
        clsImportFunction.AddParameter("format", Chr(34) & "csv" & Chr(34))

        clsImportFunction.SetAssignTo(ucrNewDataFrameName.GetText)
        ucrBase.clsRsyntax.SetBaseRFunction(clsImportFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If (Not ucrInputProjectID.IsEmpty OrElse Not ucrInputProjectName.IsEmpty) AndAlso Not ucrInputFormat.IsEmpty AndAlso ucrNewDataFrameName.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub CoreControls_ControlContentsChanged() Handles ucrInputProjectID.ControlContentsChanged, ucrInputProjectName.ControlContentsChanged, ucrInputFormat.ControlContentsChanged, ucrNewDataFrameName.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class