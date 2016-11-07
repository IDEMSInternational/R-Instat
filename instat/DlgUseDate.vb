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
Imports RDotNet
Public Class dlgUseDate
    Public bFirstLoad As Boolean = True
    Private Sub dlgUseDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.iHelpTopicID = 462

    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        chkDayInMonth.Checked = False
        chkDayInYear.Checked = False
        chkDayYear.Checked = False
        chkDecade.Checked = False
        chkLeapYear.Checked = False
        chkMonth.Checked = False
        chkPentade.Checked = False
        chkWeek.Checked = False
        chkWeekDay.Checked = False
        chkYear.Checked = False


    End Sub
    'Disabling TesOKEnabled by Ensuring in all cases its disabled
    Private Sub TestOKEnabled()
        If Not ucrReceiverUseDate.IsEmpty Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(False)
        End If

    End Sub


End Class