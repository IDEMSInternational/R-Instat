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
    Private lstLayerComplete As New List(Of Boolean)

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

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim clsNewGeomFunction As New RFunction
        Dim clsNewAesFunction As New RFunction

        sdgLayerOptions.SetupLayer(clsNewGeomFunction, clsNewAesFunction, False, False)
        sdgLayerOptions.ShowDialog()
        '        ucrBase.OKEnabled(sdgLayerOptions.ucrGeomWithAes.TestForOkEnabled())
        FillLayers()
    End Sub

    Public Sub FillLayers()
        Dim strLayer As String

        strLayer = sdgLayerOptions.ucrGeomWithAes.cboGeomList.SelectedItem
        If lstLayers.Items.ContainsKey(strLayer) Then
            lstLayerComplete(lstLayers.Items.IndexOfKey(strLayer)) = sdgLayerOptions.TestForOKEnabled()
        Else
            lstLayers.Items.Add(strLayer)
            lstLayerComplete.Add(sdgLayerOptions.TestForOKEnabled())
        End If

        If sdgLayerOptions.TestForOKEnabled() Then
            lstLayers.Items(lstLayers.Items.IndexOfKey(strLayer)).ForeColor = Color.Green

        Else
            lstLayers.Items(lstLayers.Items.IndexOfKey(strLayer)).ForeColor = Color.Red
        End If
        ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=sdgLayerOptions.clsGeomFunction.Clone)

    End Sub

    Private Sub TestOKEnabled()
        Dim bTemp As Boolean
        For Each bTemp In lstLayerComplete
            If Not bTemp Then
                Exit For
            End If
        Next
        ucrBase.OKEnabled(bTemp)
    End Sub
End Class
