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
    Private clsTypes As RFunction
    Private bDefaultsSet As Boolean = True

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
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 572
        'TODO not yet implemented
        lblKeyColumns.Hide()
        ucrInputKeyCheck.Hide()
        ucrInputKeyColumns.Hide()
        lblKeyCheck.Hide()
        cmdModify.Hide()

        ucrSelectorOptionsByContext.SetParameterIsString()
        ucrSelectorOptionsByContext.SetParameter(New RParameter("data_name", 0))

        ucrReceiverOption1.Selector = ucrSelectorOptionsByContext
        ucrReceiverOption1.SetParameterIsString()
        ucrReceiverOption1.SetParameter(New RParameter("option_1", 1))
        ucrReceiverOption1.bExcludeFromSelector = True

        ucrReceiverOptionOther.Selector = ucrSelectorOptionsByContext
        ucrReceiverOptionOther.SetParameterIsString()
        ucrReceiverOptionOther.SetParameter(New RParameter("option_other", 2))
        ucrReceiverOptionOther.bExcludeFromSelector = True

        ucrReceiverContext1.Selector = ucrSelectorOptionsByContext
        ucrReceiverContext1.SetParameterIsString()
        ucrReceiverContext1.SetParameter(New RParameter("context_1", 3))
        ucrReceiverContext1.bExcludeFromSelector = True

        ucrReceiverContext2.Selector = ucrSelectorOptionsByContext
        ucrReceiverContext2.SetParameterIsString()
        ucrReceiverContext2.SetParameter(New RParameter("context_2", 4))
        ucrReceiverContext2.bExcludeFromSelector = True

        ucrReceiverContext3.Selector = ucrSelectorOptionsByContext
        ucrReceiverContext3.SetParameterIsString()
        ucrReceiverContext3.SetParameter(New RParameter("context_3", 5))
        ucrReceiverContext3.bExcludeFromSelector = True

        ucrReceiverContext4.Selector = ucrSelectorOptionsByContext
        ucrReceiverContext4.SetParameterIsString()
        ucrReceiverContext4.SetParameter(New RParameter("context_4", 6))
        ucrReceiverContext4.bExcludeFromSelector = True

        ucrReceiverContextOther.Selector = ucrSelectorOptionsByContext
        ucrReceiverContextOther.SetParameterIsString()
        ucrReceiverContextOther.SetParameter(New RParameter("context_other", 7))
        ucrReceiverContextOther.bExcludeFromSelector = True

        ucrReceiverMeasurement1.Selector = ucrSelectorOptionsByContext
        ucrReceiverMeasurement1.SetParameterIsString()
        ucrReceiverMeasurement1.SetParameter(New RParameter("measurement_1", 8))
        ucrReceiverMeasurement1.bExcludeFromSelector = True

        ucrReceiverMeasurementOther.Selector = ucrSelectorOptionsByContext
        ucrReceiverMeasurementOther.SetParameterIsString()
        ucrReceiverMeasurementOther.SetParameter(New RParameter("measurement_other", 9))
        ucrReceiverMeasurementOther.bExcludeFromSelector = True

        ucrReceiverID1.Selector = ucrSelectorOptionsByContext
        ucrReceiverID1.SetParameterIsString()
        ucrReceiverID1.SetParameter(New RParameter("id_1", 10))
        ucrReceiverID1.bExcludeFromSelector = True

        ucrReceiverIDOther.Selector = ucrSelectorOptionsByContext
        ucrReceiverIDOther.SetParameterIsString()
        ucrReceiverIDOther.SetParameter(New RParameter("id_other", 11))
        ucrReceiverIDOther.bExcludeFromSelector = True

        ucrReceiverBlocking1.Selector = ucrSelectorOptionsByContext
        ucrReceiverBlocking1.SetParameterIsString()
        ucrReceiverBlocking1.SetParameter(New RParameter("blocking_1", 12))
        ucrReceiverBlocking1.bExcludeFromSelector = True

        ucrReceiverBlockingOther.Selector = ucrSelectorOptionsByContext
        ucrReceiverBlockingOther.SetParameterIsString()
        ucrReceiverBlockingOther.SetParameter(New RParameter("blocking_other", 13))
        ucrReceiverBlockingOther.bExcludeFromSelector = True
    End Sub

    Private Sub SetDefaults()
        bDefaultsSet = False
        clsDefineOptionsByContext = New RFunction
        clsTypes = New RFunction

        ucrSelectorOptionsByContext.Reset()
        ucrReceiverOption1.SetMeAsReceiver()

        clsTypes.SetRCommand("list")

        clsDefineOptionsByContext.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$define_as_options_by_context")
        clsDefineOptionsByContext.AddParameter("obyc_types", clsRFunctionParameter:=clsTypes, iPosition:=1)
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefineOptionsByContext)
        bDefaultsSet = True
    End Sub

    Private Sub SetRCodeforControls(bResetControls As Boolean)
        ucrSelectorOptionsByContext.SetRCode(clsDefineOptionsByContext, bResetControls)

        ucrReceiverOption1.SetRCode(clsTypes, bResetControls)
        ucrReceiverOptionOther.SetRCode(clsTypes, bResetControls)
        ucrReceiverContext1.SetRCode(clsTypes, bResetControls)
        ucrReceiverContext2.SetRCode(clsTypes, bResetControls)
        ucrReceiverContext3.SetRCode(clsTypes, bResetControls)
        ucrReceiverContext4.SetRCode(clsTypes, bResetControls)
        ucrReceiverContextOther.SetRCode(clsTypes, bResetControls)
        ucrReceiverMeasurement1.SetRCode(clsTypes, bResetControls)
        ucrReceiverMeasurementOther.SetRCode(clsTypes, bResetControls)
        ucrReceiverID1.SetRCode(clsTypes, bResetControls)
        ucrReceiverIDOther.SetRCode(clsTypes, bResetControls)
        ucrReceiverBlocking1.SetRCode(clsTypes, bResetControls)
        ucrReceiverBlockingOther.SetRCode(clsTypes, bResetControls)

        SetColumnStructureInReceiver()
    End Sub

    Private Sub TestOkEnabled()
        If (Not ucrReceiverOptionOther.IsEmpty()) OrElse (Not ucrReceiverContextOther.IsEmpty()) OrElse (Not ucrReceiverMeasurementOther.IsEmpty()) Then
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
            ucrReceiverOption1.AddItemsWithMetadataProperty(ucrSelectorOptionsByContext.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"option_1_label"})
            ucrReceiverOptionOther.AddItemsWithMetadataProperty(ucrSelectorOptionsByContext.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"option_other_label"})

            ucrReceiverContext1.AddItemsWithMetadataProperty(ucrSelectorOptionsByContext.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"context_1_label"})
            ucrReceiverContext2.AddItemsWithMetadataProperty(ucrSelectorOptionsByContext.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"context_2_label"})
            ucrReceiverContext3.AddItemsWithMetadataProperty(ucrSelectorOptionsByContext.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"context_3_label"})
            ucrReceiverContext4.AddItemsWithMetadataProperty(ucrSelectorOptionsByContext.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"context_4_label"})
            ucrReceiverContextOther.AddItemsWithMetadataProperty(ucrSelectorOptionsByContext.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"context_other_label"})

            ucrReceiverMeasurement1.AddItemsWithMetadataProperty(ucrSelectorOptionsByContext.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"measurement_1_label"})
            ucrReceiverMeasurementOther.AddItemsWithMetadataProperty(ucrSelectorOptionsByContext.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"measurement_other_label"})

            ucrReceiverID1.AddItemsWithMetadataProperty(ucrSelectorOptionsByContext.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"id_1_label"})
            ucrReceiverIDOther.AddItemsWithMetadataProperty(ucrSelectorOptionsByContext.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"id_other_label"})

            ucrReceiverBlocking1.AddItemsWithMetadataProperty(ucrSelectorOptionsByContext.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"blocking_1_label"})
            ucrReceiverBlockingOther.AddItemsWithMetadataProperty(ucrSelectorOptionsByContext.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"blocking_other_label"})

            ucrReceiverOption1.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrSelectorOptionsByContext_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorOptionsByContext.ControlValueChanged
        SetColumnStructureInReceiver()
    End Sub

    Private Sub ucrReceiverOptions_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverOptionOther.ControlContentsChanged, ucrReceiverContextOther.ControlContentsChanged, ucrReceiverMeasurementOther.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class