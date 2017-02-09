﻿' Instat-R
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
Public Class dlgUnusedLevels
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgUnusedLevels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub ReopenDialog()

    End Sub
    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction

        ucrSelectorFactorColumn.Reset()

        ' Set default RFunction as the base function
        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$drop_unused_factor_levels")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())

    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub


    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 40

        'Set receiver
        ucrReceiverFactorColumn.Selector = ucrSelectorFactorColumn
        ucrReceiverFactorColumn.SetMeAsReceiver()
        ucrReceiverFactorColumn.SetIncludedDataTypes({"factor"})
        ucrRemoveUnusedFactorLevels.SetReceiver(ucrReceiverFactorColumn)
        ucrReceiverFactorColumn.SetParameter(New RParameter("col_name", 1))
        ucrReceiverFactorColumn.SetParameterIsString()

        'Set selector data frame
        ucrSelectorFactorColumn.SetParameter(New RParameter("data_name", 0))
        ucrSelectorFactorColumn.SetParameterIsString()

    End Sub

    Private Sub ucrBase_clickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If ucrReceiverFactorColumn.IsEmpty() Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactorColumn.ControlContentsChanged
        TestOKEnabled()
    End Sub

End Class