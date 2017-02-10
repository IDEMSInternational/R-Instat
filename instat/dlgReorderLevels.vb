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
Public Class dlgReorderLevels
    Public bFirstLoad As Boolean = True
    Private clsDefaultFunction As New RFunction
    Private Sub dlgReorderLevels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 36
        ucrBase.clsRsyntax.iCallType = 0

        ucrSelectorFactorLevelsToReorder.SetParameter(New RParameter("data_name", 0))
        ucrSelectorFactorLevelsToReorder.SetParameterIsString()

        ucrReceiverFactor.Selector = ucrSelectorFactorLevelsToReorder
        ucrReceiverFactor.SetMeAsReceiver()
        ucrReceiverFactor.SetIncludedDataTypes({"factor"})
        ucrReceiverFactor.SetParameter(New RParameter("col_name", 1))
        ucrReceiverFactor.SetParameterIsString()

        ucrReorderFactor.setReceiver(ucrReceiverFactor)
        ucrReorderFactor.setDataType("factor")
        'ucrReorderFactor.SetParameter(New RParameter("new_level_names"))
        'ucrReorderFactor.SetParameterIsString()

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$reorder_factor_levels")

    End Sub

    Private Sub SetDefaults()
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        ucrSelectorFactorLevelsToReorder.Reset()
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
        TestOKEnabled()
    End Sub

    Private Sub ReOpenDialog()
        TestOKEnabled()
    End Sub

    'this should be removed once the control has inherited from ucrcore
    Private Sub ucrReorderFactor_Leave(sender As Object, e As EventArgs) Handles ucrReorderFactor.Leave
        ucrBase.clsRsyntax.AddParameter("new_level_names", ucrReorderFactor.GetVariableNames)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverFactor.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorFactorLevelsToReorder.ControlContentsChanged, ucrReceiverFactor.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class