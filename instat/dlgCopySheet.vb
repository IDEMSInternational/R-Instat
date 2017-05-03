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
Public Class dlgCopySheet
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Dim strSelectedDataFrame As String = ""
    Private clsCopySheet As New RFunction
    Private Sub dlgCopySheet_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 263

        'ucrNewName
        ucrNewDataFrameName.SetParameter(New RParameter("new_name", 1))
        ucrNewDataFrameName.SetValidationTypeAsRVariable()

        'ucrDataFrame
        ucrDataFrameCopySheets.SetParameter(New RParameter("data_name", 0))
        ucrDataFrameCopySheets.SetParameterIsString()

        ucrInputLabel.SetParameter(New RParameter("label", 2))
    End Sub

    Private Sub SetDefaults()
        clsCopySheet = New RFunction

        ucrNewDataFrameName.Reset()
        ucrDataFrameCopySheets.Reset()
        ucrInputLabel.Reset()
        ucrInputLabel.SetName("")
        CheckAutoName()

        clsCopySheet.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$copy_data_frame")

        ucrBase.clsRsyntax.SetBaseRFunction(clsCopySheet)
    End Sub


    Public Sub SetCurrentDataframe(strDataFrame As String)
        strSelectedDataFrame = strDataFrame
        ucrDataFrameCopySheets.SetDataframe(strSelectedDataFrame)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If ((Not ucrNewDataFrameName.IsEmpty) AndAlso (ucrDataFrameCopySheets.cboAvailableDataFrames.SelectedItem <> ucrNewDataFrameName.GetText) AndAlso (ucrDataFrameCopySheets.cboAvailableDataFrames.Text <> "")) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub Control_ContentsChanged(ucrChangedControl As ucrCore) Handles ucrDataFrameCopySheets.ControlContentsChanged, ucrNewDataFrameName.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrDataFrameToRename_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrDataFrameCopySheets.ControlValueChanged
        CheckAutoName()
    End Sub


    Private Sub CheckAutoName()
        If Not ucrNewDataFrameName.bUserTyped Then
            ucrNewDataFrameName.SetName(ucrDataFrameCopySheets.cboAvailableDataFrames.Text & "_copy")
        End If
    End Sub

End Class