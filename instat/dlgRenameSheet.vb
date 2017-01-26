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
Public Class dlgRenameSheet
    Public bFirstLoad As Boolean = True
    Private clsDefaultFunction As New RFunction
    Private Sub dlgRenameSheet_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)

        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()
        'Reseting ucrDataFrame to ensure that it displays the current data frame on the grid 
        ucrDataFrameToRename.Reset()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 61

        ucrInputNewName.SetParameter(New RParameter("new_value"))
        ucrInputNewName.SetValidationTypeAsRVariable()
        ucrInputNewName.SetName(ucrDataFrameToRename.cboAvailableDataFrames.SelectedItem)

        ucrDataFrameToRename.SetParameter(New RParameter("data_name"))
        ucrDataFrameToRename.SetParameterIsString()

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$rename_dataframe")
    End Sub

    Private Sub SetDefaults()
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
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
End Class