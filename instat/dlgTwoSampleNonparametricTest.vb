﻿' R- Instat
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
Public Class dlgTwoSampleNonparametricTest
    Public bFirstLoad As Boolean = True
    Private Sub dlgTwoSampleNonparametricTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrReceiverVariable.Selector = ucrTwoSampleSelector
        ucrReceiverFactor.Selector = ucrTwoSampleSelector
        ucrReceiverFactor.SetDataType("factor")

        If bFirstLoad Then
            'setDeafaults
        End If
    End Sub
    Private Sub SetDefaults()
        ucrTwoSampleSelector.Reset()
        rdoDataColandFactorCol.Focus()
    End Sub
    Private Sub TestOkEnabled()

    End Sub
    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 182
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub
End Class