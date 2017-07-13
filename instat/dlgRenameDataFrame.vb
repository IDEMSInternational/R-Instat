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
Public Class dlgRenameDataFrame
    Public bFirstLoad As Boolean = True
    Dim strSelectedDataFrame As String = ""
    Private bReset As Boolean = True
    Private clsRename As New RFunction
    Private Sub dlgRenameDataFrame_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 61

        'ucrDataFrame
        ucrDataFrameToRename.SetParameter(New RParameter("data_name", 0))
        ucrDataFrameToRename.SetParameterIsString()

        'ucrNewName
        ucrInputNewName.SetParameter(New RParameter("new_value", 1))
        ucrInputNewName.SetValidationTypeAsRVariable()

        ucrInputLabel.SetParameter(New RParameter("label", 2))
    End Sub

    Private Sub SetDefaults()
        clsRename = New RFunction

        ucrInputNewName.Reset()
        ucrDataFrameToRename.Reset()
        ucrInputLabel.Reset()
        ucrInputLabel.SetName("")
        CheckAutoName()

        clsRename.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$rename_dataframe")

        ucrBase.clsRsyntax.SetBaseRFunction(clsRename)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If ((Not ucrInputNewName.IsEmpty) AndAlso (ucrDataFrameToRename.cboAvailableDataFrames.Text <> "")) AndAlso (Not ucrDataFrameToRename.cboAvailableDataFrames.Items.Contains(ucrInputNewName.GetText)) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub CheckAutoName()
        If Not ucrInputNewName.bUserTyped Then
            ucrInputNewName.SetName(ucrDataFrameToRename.cboAvailableDataFrames.SelectedItem)
        End If
    End Sub

    Public Sub SetCurrentDataframe(strDataFrame As String)
        strSelectedDataFrame = strDataFrame
        ucrDataFrameToRename.SetDataframe(strSelectedDataFrame)
    End Sub

    Private Sub ucrDataFrameToRename_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrDataFrameToRename.ControlValueChanged
        CheckAutoName()
    End Sub

    Private Sub ucrInputNewName_ContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputNewName.ControlContentsChanged, ucrDataFrameToRename.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class