﻿' Instat-R
' Copyright (C) 2015

' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.

' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Public Class dlgReorderSheet
    Private bReset As Boolean = True
    Private bFirstLoad As Boolean = True
    Private clsReorderDataFrame As New RFunction
    Private Sub dlgReorderSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            initialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub SetDefaults()
        clsReorderDataFrame = New RFunction
        ucrSheetsToReorder.Reset()
        clsReorderDataFrame.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$reorder_dataframes")
        ucrBase.clsRsyntax.SetBaseRFunction(clsReorderDataFrame)
    End Sub

    Private Sub initialiseDialog()
        ucrBase.iHelpTopicID = 62
        ucrSheetsToReorder.setDataType("data frame")
        ucrSheetsToReorder.SetParameter(New RParameter("data_frames_order", 0))
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrSheetsToReorder.isEmpty Then
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

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSheetsToReorder.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class