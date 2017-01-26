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
Public Class dlgDeleteSheet
    Public bFirstLoad As Boolean = True
    Private clsDefaultFunction As New RFunction
    Private Sub dlgDeleteSheet_Load(sender As Object, e As EventArgs) Handles Me.Load
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

    Private Sub TestOKEnabled()
        If ucrDataFrameToDelete.cboAvailableDataFrames.Text <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ReopenDialog()
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 63
        ucrDataFrameToDelete.SetParameter(New RParameter("data_name"))
        ucrDataFrameToDelete.SetParameterIsString()
        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$delete_dataframe")
        clsDefaultFunction.AddParameter(ucrDataFrameToDelete.GetParameter(), 0)
    End Sub

    Private Sub SetDefaults()
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        ucrDataFrameToDelete.Reset()
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrDataFrameToDelete.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class