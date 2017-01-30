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
Public Class dlgReferenceLevel
    Private clsReferenceLevel As New RFunction
    Public bFirstLoad As Boolean = True
    Private Sub dlgReferenceLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 38
        ucrReceiverReferenceLevels.Selector = ucrSelectorForReferenceLevels
        ucrReceiverReferenceLevels.SetMeAsReceiver()
        ucrReceiverReferenceLevels.SetIncludedDataTypes({"factor"})
        ucrReceiverReferenceLevels.SetExcludedDataTypes({"ordered,factor"})
        ucrFactorReferenceLevels.SetReceiver(ucrReceiverReferenceLevels)
        ucrFactorReferenceLevels.SetAsSingleSelector()

        ucrSelectorForReferenceLevels.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForReferenceLevels.SetParameterIsString()

        ucrReceiverReferenceLevels.SetParameter(New RParameter("col_name", 1))
        ucrReceiverReferenceLevels.SetParameterIsString()

        ucrFactorReferenceLevels.SetParameter(New RParameter("new_ref_level", 2))
        clsReferenceLevel.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_factor_reference_level")
    End Sub

    Private Sub SetDefaults()
        ucrSelectorForReferenceLevels.Reset()
        ucrSelectorForReferenceLevels.Focus()
        ucrBase.clsRsyntax.SetBaseRFunction(clsReferenceLevel.Clone())
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverReferenceLevels.IsEmpty() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverReferenceLevels_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverReferenceLevels.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class