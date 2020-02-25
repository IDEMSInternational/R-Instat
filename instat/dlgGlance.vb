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

Public Class dlgGlance
    Public bfirstload As Boolean = True
    Public bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsRSyntax As RSyntax

    Private Sub dlgGlance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bfirstload Then
            InitialiseDialog()
            bfirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrModelReceiver.Selector = ucrModelSelector
        ucrChkDisplayinOutput.SetText("Display in Output")
        ucrSaveNewDataFrame.SetPrefix("New data frame")
        ucrSaveNewDataFrame.SetIsComboBox()
        ucrSaveNewDataFrame.SetSaveTypeAsModel()
        ucrSaveNewDataFrame.SetCheckBoxText("Save test object")
        ucrSaveNewDataFrame.SetAssignToIfUncheckedValue("Last_Test")
        ucrSaveNewDataFrame.SetDataFrameSelector(ucrModelSelector.ucrAvailableDataFrames)

    End Sub

    Private Sub SetDefaults()

    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)

    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub
End Class