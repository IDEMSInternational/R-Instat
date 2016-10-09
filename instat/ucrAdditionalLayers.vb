
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

Public Class ucrAdditionalLayers
    Public clsRSyntax As RSyntax
    Public clsRggplotFunction As New RFunction
    Public clsGgplotAesFunction As New RFunction
    Public bFirstLoad As Boolean = True
    Public lstLayerComplete As New List(Of Boolean)
    Public iLayerIndex As Integer
    Private strGlobalDataFrame As String
    Public bSetGlobalIsDefault As Boolean

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub SetRSyntax(clsRSyntaxIn As RSyntax)
        clsRSyntax = clsRSyntaxIn
    End Sub

    Public Sub SetGGplotFunction(clsRggplotFunc As RFunction)
        clsRggplotFunction = clsRggplotFunc
    End Sub

    Public Sub SetAesFunction(clsAesFunc As RFunction)
        clsGgplotAesFunction = clsAesFunc
    End Sub

    Private Sub ucrAdditionalLayers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub
    Private Sub SetDefaults()
        iLayerIndex = 0
        lstLayers.Clear()
        lstLayerComplete.Clear()
        strGlobalDataFrame = ""
        bSetGlobalIsDefault = True
        'This bSetGlobalIsDefault seems to stay True forever, maybe source of some of the errors ? Where is this used ?
        SetEditDeleteEnabled()
    End Sub

    Private Sub InitialiseControl()

    End Sub
    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=Nothing, clsTempAesFunc:=clsGgplotAesFunction, bFixAes:=False, bFixGeom:=False, strDataframe:=strGlobalDataFrame, bUseGlobalAes:=(bSetGlobalIsDefault AndAlso lstLayers.Items.Count = 0))
        ParentForm.SendToBack()
        sdgLayerOptions.ShowDialog()
        strGlobalDataFrame = sdgLayerOptions.strGlobalDataFrame
        AddLayers()
    End Sub

    Private Sub SetEditDeleteEnabled()
        If lstLayers.SelectedItems.Count = 1 Then
            cmdDelete.Enabled = True
            cmdEdit.Enabled = True
        Else
            cmdDelete.Enabled = False
            cmdEdit.Enabled = False
        End If
    End Sub
    Private Sub lstLayers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstLayers.SelectedIndexChanged
        SetEditDeleteEnabled()
    End Sub
    Public Sub AddLayers(Optional lviCurrentItem As ListViewItem = Nothing)
        Dim lviLayer As ListViewItem
        Dim strLayerName As String

        If lviCurrentItem Is Nothing Then
            iLayerIndex = iLayerIndex + 1
            strLayerName = iLayerIndex & "." & sdgLayerOptions.ucrGeomWithAes.cboGeomList.SelectedItem
            lviLayer = New ListViewItem(text:=strLayerName)
            lstLayers.Items.Add(lviLayer)
            lstLayerComplete.Add(sdgLayerOptions.TestForOKEnabled())
        Else
            lviLayer = lviCurrentItem
            lstLayerComplete(lstLayers.Items.IndexOf(lviLayer)) = sdgLayerOptions.TestForOKEnabled()
            strLayerName = lviCurrentItem.Text
        End If

        If sdgLayerOptions.TestForOKEnabled() Then
            lstLayers.Items(lstLayers.Items.IndexOf(lviLayer)).ForeColor = Color.Green
        Else
            lstLayers.Items(lstLayers.Items.IndexOf(lviLayer)).ForeColor = Color.Red
        End If

        clsRSyntax.SetOperatorParameter(False, strParameterName:=strLayerName, clsRFunc:=sdgLayerOptions.clsGeomFunction.Clone())

        dlgGeneralForGraphics.TestOKEnabled()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If lstLayers.SelectedItems.Count = 1 Then
            clsRSyntax.RemoveOperatorParameter(lstLayers.SelectedItems(0).Text)
            lstLayerComplete.RemoveAt(lstLayers.SelectedIndices(0))
            lstLayers.Items.Remove(lstLayers.SelectedItems(0))
        End If
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        Dim clsSelectedGeom As RFunction
        Dim clsLocalAes As RFunction

        clsSelectedGeom = clsRSyntax.GetParameter(lstLayers.SelectedItems(0).Text).clsArgumentFunction
        If clsSelectedGeom.GetParameter("mapping") IsNot Nothing Then
            clsLocalAes = clsSelectedGeom.GetParameter("mapping").clsArgumentFunction
        Else
            clsLocalAes = Nothing
        End If
        sdgLayerOptions.SetupLayer(clsTempGgPlot:=dlgGeneralForGraphics.clsRggplotFunction, clsTempGeomFunc:=clsSelectedGeom, clsTempAesFunc:=dlgGeneralForGraphics.clsGgplotAesFunction, bFixAes:=False, bFixGeom:=True, strDataframe:=strGlobalDataFrame, bUseGlobalAes:=False, clsTempLocalAes:=clsLocalAes)
        sdgLayerOptions.ShowDialog()
        AddLayers(lstLayers.SelectedItems(0))
    End Sub

    Public Sub Reset()
        SetDefaults()
    End Sub

End Class
