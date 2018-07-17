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
Public Class dlgAnonymiseIDColumn
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private clsHashFunction As New RFunction
    Private Sub dlgAnonymiseIDColumn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverIDColumn.Selector = ucrSelectorAnonymiseIDColumn
        ucrSelectorAnonymiseIDColumn.bUseCurrentFilter = False

        ucrReceiverIDColumn.SetParameter(New RParameter("x", 0))
        ucrReceiverIDColumn.SetParameterIsRFunction()

        ucrInputTextSalt.SetParameter(New RParameter("salt", 1))

        ucrSaveAnonymisedColumn.SetPrefix("Hash")
        ucrSaveAnonymisedColumn.SetSaveTypeAsColumn()
        ucrSaveAnonymisedColumn.SetDataFrameSelector(ucrSelectorAnonymiseIDColumn.ucrAvailableDataFrames)
        ucrSaveAnonymisedColumn.SetIsTextBox()
        ucrSaveAnonymisedColumn.SetLabelText("Column Name:")
    End Sub

    Private Sub SetDefaults()
        clsHashFunction = New RFunction

        ucrReceiverIDColumn.SetMeAsReceiver()
        ucrSelectorAnonymiseIDColumn.Reset()
        ucrSaveAnonymisedColumn.Reset()

        clsHashFunction.SetRCommand("hashed_id")
        clsHashFunction.AddParameter("algo", Chr(34) & "crc32" & Chr(34), iPosition:=2)

        ucrBase.clsRsyntax.SetBaseRFunction(clsHashFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverIDColumn.IsEmpty AndAlso Not ucrInputTextSalt.IsEmpty AndAlso ucrSaveAnonymisedColumn.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrReceiverIDColumn_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverIDColumn.ControlContentsChanged, ucrInputTextSalt.ControlContentsChanged, ucrSaveAnonymisedColumn.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class