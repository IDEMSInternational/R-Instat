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
    Private clsCopySheet As New RFunction
    Private Sub dlgCopySheet_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        Else
            ReopenDialogue()
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub ReopenDialogue()
        'Reseting ucrDataFrame to ensure that it displays the current data frame on the grid 
        ucrDataFrameCopySheets.Reset()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 263

        'ucrNewName
        ucrNewDataFrameName.SetParameter(New RParameter("new_name"))
        ucrNewDataFrameName.SetValidationTypeAsRVariable()

        'ucrDataFrame
        ucrDataFrameCopySheets.SetParameter(New RParameter("data_name"))
        ucrDataFrameCopySheets.SetParameterIsString()

        'Default Function
    End Sub

    Private Sub SetDefaults()
        clsCopySheet = New RFunction

        ucrNewDataFrameName.Reset()
        ucrDataFrameCopySheets.Reset()
        CheckAutoName()

        clsCopySheet.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$copy_data_frame")

        ucrBase.clsRsyntax.SetBaseRFunction(clsCopySheet)
    End Sub

    Private Sub ReopenDialog()
        'Reseting ucrDataFrame to ensure that it displays the current data frame on the grid 
        ucrDataFrameCopySheets.Reset()
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