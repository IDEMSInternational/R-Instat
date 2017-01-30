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
Public Class dlgReorderLevels
    Public bFirstLoad As Boolean = True
    Private clsDefaultFunction As New RFunction
    Private Sub dlgReorderLevels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaultSettings()
            bFirstLoad = False
        End If
        TestOKEnabled()
    End Sub
    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 36
        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$reorder_factor_levels")

        'Set Receivers and column parameter
        ucrReceiverFactor.Selector = ucrSelectorFactorLevelsToReorder
        ucrReceiverFactor.SetMeAsReceiver()
        ucrReceiverFactor.SetIncludedDataTypes({"factor"})
        ucrReceiverFactor.SetParameter(New RParameter("col_name"))
        ucrReceiverFactor.SetParameterIsString()

        'Set reorder scroll list view
        ucrReorderFactor.setReceiver(ucrReceiverFactor)
        ucrReorderFactor.setDataType("factor")

        'Set data farme paramater
        ucrSelectorFactorLevelsToReorder.SetParameter(New RParameter("data_name", 0))
        ucrSelectorFactorLevelsToReorder.SetParameterIsString()

        'Set column Parameter
        ucrReorderFactor.SetParameter(New RParameter("new_level_names"))
        ' ucrReorderFactor.SetParameterIsString()
        ' ucrReorderFactor.SetParameterIsString()

    End Sub
    Private Sub SetDefaultSettings()
        ' Set default RFunction as the base function
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        ucrSelectorFactorLevelsToReorder.Reset()
        ucrSelectorFactorLevelsToReorder.Focus()
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
    End Sub

    'Private Sub ucrReorderFactor_Leave(sender As Object, e As EventArgs) Handles ucrReorderFactor.Leave
    '    ucrBase.clsRsyntax.AddParameter("new_level_names", ucrReorderFactor.GetVariableNames)
    'End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverFactor.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaultSettings()
        TestOKEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactor.ControlContentsChanged
        TestOKEnabled()
    End Sub

End Class