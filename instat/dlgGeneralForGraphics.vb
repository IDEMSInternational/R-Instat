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
Imports instat.Translations
Public Class dlgGeneralForGraphics
    Private clsRggplotFunction As New RFunction
    Private bFirstLoad As Boolean = True
    Public lstLayer As String

    Private Sub dlgGeneralForGraphics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()

        End If
        autoTranslate(Me)
        ucrBase.OKEnabled(False)
    End Sub

    Private Sub InitialiseDialog()
        'setting the base ggplot functions
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)
        ucrBase.iHelpTopicID = 356
    End Sub
    Private Sub SetDefaults()
        cmdDelete.Enabled = False
        cmdEdit.Enabled = False
        lstLayers.Clear()
    End Sub
    Private Sub ReopenDialog()

    End Sub
    Public Sub TestOkEnabled()
        'thinking this would be useful to check if all receivers for mandatory are filled
        'If Not sdgLayerOptions.ucrGeomWithAes.ucrReceiverParam1.IsEmpty Then
        '    ucrBase.OKEnabled(ucrGeomAes.bEnabled)
        'Else
        '    ucrBase.OKEnabled(ucrGeomAes.bEnabled)
        'End If

        ''create a loop for mandatory receivers 
    End Sub
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        sdgLayerOptions.ShowDialog()
        ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=sdgLayerOptions.clsGeomFunction)
        FillLayers()
        ucrBase.OKEnabled(sdgLayerOptions.ucrGeomWithAes.TestForOkEnabled())
    End Sub
    Public Sub FillLayers()
        lstLayer = sdgLayerOptions.ucrGeomWithAes.cboGeomList.SelectedItem
        lstLayers.Items.Add(lstLayer)
    End Sub
End Class
