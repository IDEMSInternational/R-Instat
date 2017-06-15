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
Imports instat
Imports instat.Translations
Public Class dlgDeleteObjects
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgDeleteObjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub ReopenDialog()
        ucrSelectorDeleteObject.Reset() ' temporary fix
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 352

        ' Selector
        ucrSelectorDeleteObject.SetParameter(New RParameter("data_name", 0))
        ucrSelectorDeleteObject.SetParameterIsString()
        ucrSelectorDeleteObject.SetItemType("object")

        ' Receiver
        ucrReceiverObjectsToDelete.SetParameter(New RParameter("object_names", 1))
        ucrReceiverObjectsToDelete.SetParameterIsString()
        ucrReceiverObjectsToDelete.Selector = ucrSelectorDeleteObject
        ucrReceiverObjectsToDelete.SetMeAsReceiver()
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction

        ucrSelectorDeleteObject.Reset()

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$delete_objects")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverObjectsToDelete.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverObjectsToDelete_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverObjectsToDelete.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class
