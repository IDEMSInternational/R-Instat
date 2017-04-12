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

Imports instat
Imports instat.Translations
Public Class dlgRenameSheet
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private Sub dlgRenameSheet_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        Else
            ReopenDialog() ' Temp fix
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub ReopenDialog()
        'Reseting ucrDataFrame to ensure that it displays the current data frame on the grid 
        ucrDataFrameToRename.Reset()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 61

        ucrInputNewName.SetParameter(New RParameter("new_value"))
        ucrInputNewName.SetValidationTypeAsRVariable()

        ucrDataFrameToRename.SetParameter(New RParameter("data_name"))
        ucrDataFrameToRename.SetParameterIsString()

        ucrInputLabel.SetParameter(New RParameter("value"))

    End Sub

    ' check how changing dataframes affects it

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction
        ucrInputNewName.Reset()
        ucrDataFrameToRename.Reset()

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$rename_dataframe")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())

        CheckAutoName()
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If ((Not ucrInputNewName.IsEmpty) AndAlso (ucrDataFrameToRename.cboAvailableDataFrames.SelectedItem <> ucrInputNewName.GetText) AndAlso (ucrDataFrameToRename.cboAvailableDataFrames.Text <> "")) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrInputNewName_ContentsChanged() Handles ucrInputNewName.ControlContentsChanged, ucrDataFrameToRename.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrDataFrameToRename_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrDataFrameToRename.ControlValueChanged
        CheckAutoName()
    End Sub

    Private Sub CheckAutoName()
        If Not ucrInputNewName.bUserTyped Then
            ucrInputNewName.SetName(ucrDataFrameToRename.cboAvailableDataFrames.SelectedItem)
        End If
    End Sub
End Class