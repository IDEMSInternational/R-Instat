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
Imports System.IO
Imports instat.Translations
Public Class dlgExportRWorkspace
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDefaultFunction As New RFunction
    Private Sub dlgExportRWorkspace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)

    End Sub

    Private Sub InitialiseDialog()

        ucrSelectorForDataFrames.SetParameter(New RParameter("x", 0))

        ucrReceiverMultiple.Selector = ucrSelectorForDataFrames
        ucrReceiverMultiple.SetParameter(New RParameter("data_name", 1))

        ucrChkMetadata.SetParameter(New RParameter("metadata", 2))
        ucrChkMetadata.SetText("Metadata")
        ucrChkMetadata.SetValuesCheckedAndUnchecked("TRUE", "FALSE")



    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction
        ucrInputExportFile.IsReadOnly = True
        ucrInputExportFile.SetName("")
        ucrSelectorForDataFrames.Reset()
        ucrReceiverMultiple.SetMeAsReceiver()
    End Sub

    Private Sub TestOkEnabled()

    End Sub

End Class