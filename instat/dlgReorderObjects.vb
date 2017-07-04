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
Public Class dlgReorderObjects
    Public bFirstLoad As Boolean = True
    Public bReset As Boolean = True

    Private Sub dlgReorderObject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOKEnabled()
    End Sub


    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 351

        ' ucrSelector DataFrame
        ucrDataFrameReorder.SetParameter(New RParameter("data_name", 0))
        ucrDataFrameReorder.SetParameterIsString()

        ' ucrReorderObjects
        ucrReorderObjects.SetParameter(New RParameter("new_order", 1))

        ucrReorderObjects.setDataType("object")
        ucrReorderObjects.setDataframes(ucrDataFrameReorder)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReorderObjects.isEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction
        ucrDataFrameReorder.Reset()

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$reorder_objects")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub ucrReorderObjects_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReorderObjects.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class