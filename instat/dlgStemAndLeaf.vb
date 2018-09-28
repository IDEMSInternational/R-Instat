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

Public Class dlgStemAndLeaf
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsStemAndLeaf As New RFunction
    Private Sub dlgStemAndLeaf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.iHelpTopicID = 326

        'ucrReceiver
        ucrReceiverStemAndLeaf.SetParameter(New RParameter("x", 0))
        ucrReceiverStemAndLeaf.SetParameterIsRFunction()
        ucrReceiverStemAndLeaf.Selector = ucrStemLeafSelector
        ucrReceiverStemAndLeaf.SetIncludedDataTypes({"numeric"})
        ucrReceiverStemAndLeaf.SetMeAsReceiver()
    End Sub

    Private Sub SetDefaults()
        clsStemAndLeaf = New RFunction

        clsStemAndLeaf.SetPackageName("graphics")
        clsStemAndLeaf.SetRCommand("stem")
        ucrBase.clsRsyntax.SetBaseRFunction(clsStemAndLeaf)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverStemAndLeaf.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverStemAndLeaf_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStemAndLeaf.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class