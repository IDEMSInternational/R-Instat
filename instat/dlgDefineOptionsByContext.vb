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

Public Class dlgDefineOptionsByContext
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDefineOptionsByContext As RFunction

    Private Sub dlgDefineOptionsByContext_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrSelectorOptionsByContext.SetParameterIsString()
        ucrSelectorOptionsByContext.SetParameter(New RParameter("data_name", 0))
        ucrReceiverOptions.Selector = ucrSelectorOptionsByContext
        ucrReceiverOptions.SetParameterIsString()
        ucrReceiverOptions.SetParameter(New RParameter("option_types", 1))
        ucrReceiverOptions.bExcludeFromSelector = True

        ucrReceiverContexts.Selector = ucrSelectorOptionsByContext
        ucrReceiverContexts.SetParameterIsString()
        ucrReceiverContexts.SetParameter(New RParameter("context_types", 2))
        ucrReceiverContexts.bExcludeFromSelector = True

        ucrReceiverMeasurements.Selector = ucrSelectorOptionsByContext
        ucrReceiverMeasurements.SetParameterIsString()
        ucrReceiverMeasurements.SetParameter(New RParameter("measurement_types", 3))
        ucrReceiverMeasurements.bExcludeFromSelector = True
    End Sub

    Private Sub SetDefaults()
        clsDefineOptionsByContext = New RFunction

        ucrSelectorOptionsByContext.Reset()
        ucrReceiverOptions.SetMeAsReceiver()

        clsDefineOptionsByContext.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$define_as_options_by_context")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefineOptionsByContext)
    End Sub

    Private Sub SetRCodeforControls(bResetControls As Boolean)
        SetRCode(Me, clsDefineOptionsByContext, bResetControls)
        SetColumnStructureInReceiver()
    End Sub

    Private Sub TestOkEnabled()
        If (Not ucrReceiverOptions.IsEmpty()) OrElse (Not ucrReceiverContexts.IsEmpty()) OrElse (Not ucrReceiverMeasurements.IsEmpty()) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOkEnabled()
    End Sub

    Private Sub SetColumnStructureInReceiver()
        If ucrSelectorOptionsByContext.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrReceiverOptions.AddItemsWithMetadataProperty(ucrSelectorOptionsByContext.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"option_label"})
            ucrReceiverContexts.AddItemsWithMetadataProperty(ucrSelectorOptionsByContext.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"context_label"})
            ucrReceiverMeasurements.AddItemsWithMetadataProperty(ucrSelectorOptionsByContext.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"measurement_label"})
            ucrReceiverOptions.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrSelectorOptionsByContext_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorOptionsByContext.ControlValueChanged
        SetColumnStructureInReceiver()
    End Sub

    Private Sub ucrReceiverOptions_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverOptions.ControlContentsChanged, ucrReceiverContexts.ControlContentsChanged, ucrReceiverMeasurements.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class