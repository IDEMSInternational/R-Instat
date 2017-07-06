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
Public Class dlgReferenceLevel
    Private bFirstLoad As Boolean = True
    Public strDefaultDataFrame As String = ""
    Private bReset As Boolean = True
    Private clsSetRefLevel As New RFunction
    Private Sub dlgReferenceLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 38

        ucrSelectorForReferenceLevels.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForReferenceLevels.SetParameterIsString()

        ucrReceiverReferenceLevels.SetParameter(New RParameter("col_name", 1))
        ucrReceiverReferenceLevels.SetParameterIsString()
        ucrReceiverReferenceLevels.Selector = ucrSelectorForReferenceLevels
        ucrReceiverReferenceLevels.SetMeAsReceiver()
        ucrReceiverReferenceLevels.SetIncludedDataTypes({"factor"})
        ucrReceiverReferenceLevels.strSelectorHeading = "Factors"
        ucrReceiverReferenceLevels.SetExcludedDataTypes({"ordered,factor"})

        ucrFactorReferenceLevels.SetParameter(New RParameter("new_ref_level", 2))
        ucrFactorReferenceLevels.SetReceiver(ucrReceiverReferenceLevels)
        ucrFactorReferenceLevels.SetAsSingleSelector()
        ucrFactorReferenceLevels.SetIncludeLevels(False)
    End Sub

    Private Sub SetDefaults()
        clsSetRefLevel = New RFunction
        ucrSelectorForReferenceLevels.Reset()

        clsSetRefLevel.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_factor_reference_level")
        ucrBase.clsRsyntax.SetBaseRFunction(clsSetRefLevel)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverReferenceLevels.IsEmpty Then
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

    Private Sub SetDefaultDataFrame()
        If strDefaultDataFrame <> "" Then
            ucrSelectorForReferenceLevels.SetDataframe(strDefaultDataFrame)
        End If
        strDefaultDataFrame = ""
    End Sub

    Private Sub ucrReceiverReferenceLevels_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverReferenceLevels.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class