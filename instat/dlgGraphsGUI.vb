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

Public Class dlgGraphsGUI
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsGgplotShinny As New RFunction

    Private Sub dlgGraphsGUI_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitaliseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverGraphs.IsEmpty Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, clsGgplotShinny, bReset)
    End Sub

    Private Sub SetDefaults()
        clsGgplotShinny = New RFunction
        ucrSelectorGraphGUI.Reset()


        clsGgplotShinny.SetPackageName("ggplotgui")
        clsGgplotShinny.SetRCommand("ggplot_shiny")

        ucrBase.clsRsyntax.SetBaseRFunction(clsGgplotShinny)
    End Sub

    Private Sub InitaliseDialog()
        ucrBase.clsRsyntax.iCallType = 2

        ucrReceiverGraphs.Selector = ucrSelectorGraphGUI
        ucrReceiverGraphs.bForceAsDataFrame = True
        ucrReceiverGraphs.SetMeAsReceiver()
        ucrReceiverGraphs.SetItemType("dataframe")
        ucrReceiverGraphs.strSelectorHeading = "Dataframes"

        ucrReceiverGraphs.SetParameter(New RParameter("dataset", 0))
        ucrReceiverGraphs.SetParameterIsRFunction()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverGraphs_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverGraphs.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class
