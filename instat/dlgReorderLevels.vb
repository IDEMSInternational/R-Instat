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
Public Class dlgReorderLevels
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsReorder As New RFunction

    Private Sub dlgReorderLevels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.iHelpTopicID = 36

        'Set data frame paramater
        ucrSelectorFactorLevelsToReorder.SetParameter(New RParameter("data_name", 0))
        ucrSelectorFactorLevelsToReorder.SetParameterIsString()

        'Set Receivers and column parameter
        ucrReceiverFactor.SetParameter(New RParameter("col_name", 1))
        ucrReceiverFactor.Selector = ucrSelectorFactorLevelsToReorder
        ucrReceiverFactor.SetMeAsReceiver()
        ucrReceiverFactor.SetIncludedDataTypes({"factor"}, bStrict:=True)
        ucrReceiverFactor.strSelectorHeading = "Factors"
        ucrReceiverFactor.SetParameterIsString()

        'Set reorder scroll list view & datatype accepted
        ucrReorderFactor.SetParameter(New RParameter("new_level_names", 2))
        ucrReorderFactor.setReceiver(ucrReceiverFactor)
        ucrReorderFactor.setDataType("factor")
    End Sub

    Private Sub SetDefaults()
        clsReorder = New RFunction
        'reset
        ucrSelectorFactorLevelsToReorder.Reset()
        ' Set default function
        clsReorder.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$reorder_factor_levels")
        ucrBase.clsRsyntax.SetBaseRFunction(clsReorder)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
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
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactor.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class