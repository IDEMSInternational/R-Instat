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

Public Class ucrAdditionalLayers
    'Operator containing all parts of the ggplot command
    Public clsBaseOperator As ROperator
    'The ggplot() function usually the first parameter of clsBaseOperator
    Public clsGgplotFunction As RFunction
    'The global aes() function - global ggplot aesthetics function
    Public clsGlobalAesFunction As RFunction
    Public bFirstLoad As Boolean = True
    Public bReset As Boolean = True
    Public lstLayerComplete As New List(Of Boolean)
    Public iLayerIndex As Integer
    Private strGlobalDataFrame As String
    Public bSetGlobalIsDefault As Boolean = True
    'Deciding if the first layer needs to be used for global aesthetics. 
    'Question to be discussed: What is this variable about again ? it is linked with sdgPlots.bAdditionalLayersSetGlobal in sdgPLots.bLayersDefaultIsGolobal.
    Public Event NumberOfLayersChanged() 'This event is raised when the number of Layers in the lstLayers on ucrAdditionalLayers has been changed, then handled by testOkEnabled On GeneralForGraphics. 

    Public Sub SetRCodeForControl(Optional clsNewBaseOperator As ROperator = Nothing, Optional clsRNewggplotFunc As RFunction = Nothing, Optional clsNewAesFunc As RFunction = Nothing, Optional strNewGlobalDataFrame As String = "", Optional bReset As Boolean = False)
        Dim strTempGeomName As String

        clsBaseOperator = clsNewBaseOperator
        clsGlobalAesFunction = clsNewAesFunc
        clsGgplotFunction = clsRNewggplotFunc
        iLayerIndex = 0
        lstLayers.Clear()
        lstLayerComplete.Clear()
        lstLayers.HideSelection = False

        For Each clsTempParam In clsBaseOperator.clsParameters
            strTempGeomName = GetGeomName(clsTempParam)
            If strTempGeomName <> "" Then
                AddLayers(strTempGeomName, bFromLayerSubDialog:=False)
            End If
        Next
        strGlobalDataFrame = strNewGlobalDataFrame
    End Sub

    Private Sub ucrAdditionalLayers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetEditDeleteEnabled()
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim clsNewLocalAesFunction As New RFunction
        Dim clsNewGeomFunction As New RFunction

        'TODO add these in Ggplot default class
        clsNewLocalAesFunction.SetPackageName("ggplot2")
        clsNewLocalAesFunction.SetRCommand("aes")
        clsNewGeomFunction.SetPackageName("ggplot2")
        clsNewGeomFunction.SetRCommand("geom_boxplot")

        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsGgplotFunction, clsNewGeomFunc:=clsNewGeomFunction, clsNewGlobalAesFunc:=clsGlobalAesFunction, clsNewLocalAes:=clsNewLocalAesFunction, bFixGeom:=False, ucrNewBaseSelector:=Nothing, bApplyAesGlobally:=(bSetGlobalIsDefault AndAlso lstLayers.Items.Count = 0), iTabToDisplay:=0, strDataFrame:=strGlobalDataFrame)
        ParentForm.SendToBack()
        sdgLayerOptions.ShowDialog()
        strGlobalDataFrame = sdgLayerOptions.GetGlobalDataFrame()
        AddLayers(clsNewGeomFunction.strRCommand)
        sdgLayerOptions.tbcLayers.SelectedIndex = 0
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

    'TODO checking needs to move out of subdialog because could be adding from a reopen
    '     this means geom objects should also be accessible outside of geom user control
    Public Sub AddLayers(strGeomName As String, Optional lviCurrentItem As ListViewItem = Nothing, Optional bFromLayerSubDialog As Boolean = True)
        Dim lviLayer As ListViewItem
        Dim strLayerName As String

        If lviCurrentItem Is Nothing Then
            iLayerIndex = iLayerIndex + 1
            strLayerName = iLayerIndex & "." & strGeomName
            lviLayer = New ListViewItem(text:=strLayerName)
            lstLayers.Items.Add(lviLayer)
            If bFromLayerSubDialog Then
                lstLayerComplete.Add(sdgLayerOptions.TestForOKEnabled())
            Else
                'temporary set to True if not checking. Eventually checking can be done in all cases
                lstLayerComplete.Add(True)
            End If
        Else
            lviLayer = lviCurrentItem
            If bFromLayerSubDialog Then
                lstLayerComplete(lstLayers.Items.IndexOf(lviLayer)) = sdgLayerOptions.TestForOKEnabled()
            Else
                lstLayerComplete(lstLayers.Items.IndexOf(lviLayer)) = True
            End If
            strLayerName = lviCurrentItem.Text
        End If

        If lstLayerComplete(lstLayers.Items.IndexOf(lviLayer)) Then
            lstLayers.Items(lstLayers.Items.IndexOf(lviLayer)).ForeColor = Color.Green
        Else
            lstLayers.Items(lstLayers.Items.IndexOf(lviLayer)).ForeColor = Color.Red
        End If

        'Note: as the GeomFunction on sdgLayerOptions will be edited for different layers, it cannot be linked like clsGgplotFunction would, it needs to be cloned.
        If bFromLayerSubDialog Then
            clsBaseOperator.AddParameter(strParameterName:=strLayerName, clsRFunctionParameter:=sdgLayerOptions.clsGeomFunction.Clone(), iPosition:=iLayerIndex)
        End If
        'When the number of Layers in the lstLayers on ucrAdditionalLayers need to check if OK is enabled on dlgGeneralForGraphics.
        RaiseEvent NumberOfLayersChanged()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If lstLayers.SelectedItems.Count = 1 Then
            If clsBaseOperator.ContainsParameter(lstLayers.SelectedItems(0).Text) Then
                clsBaseOperator.RemoveParameterByName(lstLayers.SelectedItems(0).Text)
                lstLayerComplete.RemoveAt(lstLayers.SelectedIndices(0))
                lstLayers.Items.Remove(lstLayers.SelectedItems(0))
                'When the number of Layers in the lstLayers on ucrAdditionalLayers need to check if OK is enabled on dlgGeneralForGraphics.
                RaiseEvent NumberOfLayersChanged()
            Else
                MsgBox("Sorry, you cannot delete a layer that was created on the main dialog.", MsgBoxStyle.Information, "Cannot delete layer")
            End If
        End If
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        Dim clsSelectedGeomFunction As RFunction
        Dim clsLocalAes As RFunction

        'The selected geom is found as the RFunction of the appropriate RParameter of RSyntax. The name of that Parameter is the name of the selected item in the lstLayers. That one is fetched using .SelectedItems(0) as there can only be one selected item at a time when the edit button is clicked.
        If clsBaseOperator.ContainsParameter(lstLayers.SelectedItems(0).Text) Then
            clsSelectedGeomFunction = clsBaseOperator.GetParameter(lstLayers.SelectedItems(0).Text).clsArgumentCodeStructure
            If clsSelectedGeomFunction.ContainsParameter("mapping") Then
                clsLocalAes = clsSelectedGeomFunction.GetParameter("mapping").clsArgumentCodeStructure
            Else
                'TODO should come from ggplot defaults class
                clsLocalAes = New RFunction
                clsLocalAes.SetPackageName("ggplot2")
                clsLocalAes.SetRCommand("aes")
            End If

            'Warning: sdgLayerOptions should not be setup using dlgGeneralForGraphics' fields !! These fields should be given through to the ucrAdditionalLayers (which should have all these) 
            sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsGgplotFunction, clsNewGeomFunc:=clsSelectedGeomFunction, clsNewGlobalAesFunc:=clsGlobalAesFunction, clsNewLocalAes:=clsLocalAes, bFixGeom:=True, strDataFrame:=strGlobalDataFrame, bApplyAesGlobally:=False, bReset:=False, iTabToDisplay:=0)
            'It has been chosen to fix the value of bApplyAesGlobally to False as when a Layer is editted, the choice to apply the Aes globally should be reconsidered no matter what it has been during last edit.
            ParentForm.SendToBack() 'Otherwise sdgLayerOptions appears behind sdgPLotOptions
            sdgLayerOptions.ShowDialog()
            AddLayers(clsSelectedGeomFunction.strRCommand, lstLayers.SelectedItems(0))
        Else
            MsgBox("Feature not yet implemented" & Environment.NewLine & "Sorry, editing layers created on the main dialog is not currently possible in this version of R-Instat.", MsgBoxStyle.Information, "Feature not yet implemented")
        End If
    End Sub

    Private Function GetGeomName(clsParam As RParameter) As String
        Dim clsTempFunc As RFunction
        Dim strGeom As String = ""

        If clsParam IsNot Nothing AndAlso clsParam.bIsFunction AndAlso clsParam.clsArgumentCodeStructure IsNot Nothing Then
            clsTempFunc = TryCast(clsParam.clsArgumentCodeStructure, RFunction)
            If clsTempFunc IsNot Nothing Then
                If clsTempFunc.strRCommand.StartsWith("geom_") Then
                    strGeom = clsTempFunc.strRCommand
                End If
            End If
        End If
        Return strGeom
    End Function
End Class