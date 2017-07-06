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
Public Class dlgHideShowColumns
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsHiddenColumns As New RFunction
    Private Sub dlgHideShowColumns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetHiddenColumnsInReceiver()
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 167

        ucrReceiverHiddenColumns.Selector = ucrSelectorForHiddenColumns
        ucrReceiverHiddenColumns.SetMeAsReceiver()

        ucrSelectorForHiddenColumns.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForHiddenColumns.SetParameterIsString()

        ucrReceiverHiddenColumns.SetParameter(New RParameter("col_names", 1))
        ucrSelectorForHiddenColumns.bShowHiddenColumns = True
        ucrReceiverHiddenColumns.SetRDefault("c()")
        ucrReceiverHiddenColumns.SetParameterIsString()
        ucrReceiverHiddenColumns.bExcludeFromSelector = True
    End Sub

    Private Sub SetDefaults()
        Dim clsHiddenColumns = New RFunction

        ucrSelectorForHiddenColumns.Reset()
        SetHiddenColumnsInReceiver()

        clsHiddenColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_hidden_columns")
        clsHiddenColumns.AddParameter("col_names", "c()")

        ucrBase.clsRsyntax.SetBaseRFunction(clsHiddenColumns)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If ucrSelectorForHiddenColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
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

    Private Sub SetHiddenColumnsInReceiver()
        ucrReceiverHiddenColumns.AddItemsWithMetadataProperty(ucrSelectorForHiddenColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Is_Hidden", {"TRUE"})
    End Sub

    Private Sub ucrSelectorForHiddenColumns_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForHiddenColumns.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class