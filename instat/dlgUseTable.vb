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
Public Class dlgUseTable
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsRFunctionAsHTML, clsRFunctionAsRTF, clsRFunctionAsWord, ClsRFunctionAsLaTex As New RFunction

    Private Sub dlgUseTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrTablesReceiver.SetParameter(New RParameter("x", 0))
        ucrTablesReceiver.Selector = ucrTablesSelector
        ucrTablesReceiver.SetParameterIsRFunction()
        ucrTablesReceiver.SetMeAsReceiver()
        ucrTablesReceiver.strSelectorHeading = "Tables"
        ucrTablesReceiver.SetItemType(RObjectTypeLabel.Table)

        ucrPnlExportOptions.AddRadioButton(rdoAsHTML)
        ucrPnlExportOptions.AddRadioButton(rdoAsRTF)
        ucrPnlExportOptions.AddRadioButton(rdoAsWord)
        ucrPnlExportOptions.AddRadioButton(rdoAsLaTex)

        ucrChkExportTable.SetText("Export File")

    End Sub

    Private Sub SetDefaults()
        clsRFunctionAsHTML = New RFunction
        clsRFunctionAsRTF = New RFunction
        clsRFunctionAsWord = New RFunction
        ClsRFunctionAsLaTex = New RFunction


    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)

    End Sub

    Private Sub TestOKEnabled()

    End Sub
End Class