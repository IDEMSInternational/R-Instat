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
Public Class dlgHideShowColumns
    Private clsDefaultFunction As New RFunction
    Public bFirstLoad As Boolean = True
    Private Sub dlgHideShowColumns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            TestOKEnabled()
            bFirstLoad = False
        End If
        SetHiddenColumnsInReceiver()
    End Sub

    Private Sub TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 167

        ucrReceiverHiddenColumns.Selector = ucrSelectorForHiddenColumns
        ucrReceiverHiddenColumns.SetMeAsReceiver()

        ucrSelectorForHiddenColumns.SetParameter(New RParameter("data_name"))
        ucrSelectorForHiddenColumns.SetParameterIsString()

        ucrReceiverHiddenColumns.SetParameter(New RParameter("col_names"))
        ucrReceiverHiddenColumns.SetParameterIsString()

        ucrReceiverHiddenColumns.bExcludeFromSelector = True
        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_hidden_columns")
        ucrSelectorForHiddenColumns.bShowHiddenColumns = True
    End Sub

    Private Sub SetHiddenColumnsInReceiver()
        ucrReceiverHiddenColumns.AddItemsWithMetadataProperty(ucrSelectorForHiddenColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Is_Hidden", {"TRUE"})
    End Sub

    Private Sub SetDefaults()
        SetHiddenColumnsInReceiver()
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForHiddenColumns.ControlContentsChanged, ucrReceiverHiddenColumns.ControlContentsChanged
        TestOKEnabled()
    End Sub

End Class