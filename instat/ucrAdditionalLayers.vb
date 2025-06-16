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
    Public iMaxParameterPosition As Integer
    Private strGlobalDataFrame As String
    Public bSetGlobalIsDefault As Boolean = True
    Private strMainDialogGeomNames() As String
    'Deciding if the first layer needs to be used for global aesthetics. 
    'Question to be discussed: What is this variable about again ? it is linked with sdgPlots.bAdditionalLayersSetGlobal in sdgPLots.bLayersDefaultIsGolobal.
    Public Event NumberOfLayersChanged() 'This event is raised when the number of Layers in the lstLayers on ucrAdditionalLayers has been changed, then handled by testOkEnabled On GeneralForGraphics. 
    Public Sub SetRCodeForControl(Optional clsNewBaseOperator As ROperator = Nothing, Optional clsRNewggplotFunc As RFunction = Nothing, Optional clsNewAesFunc As RFunction = Nothing, Optional strNewGlobalDataFrame As String = "", Optional strMainDialogGeomParameterNames() As String = Nothing, Optional bReset As Boolean = False)
        clsBaseOperator = clsNewBaseOperator
        clsGlobalAesFunction = clsNewAesFunc
        clsGgplotFunction = clsRNewggplotFunc
        SetLayersList()
        strGlobalDataFrame = strNewGlobalDataFrame
        strMainDialogGeomNames = strMainDialogGeomParameterNames
    End Sub

    Private Sub SetLayersList()
        Dim strTempGeomName As String

        iLayerIndex = 0
        iMaxParameterPosition = 0
        lstLayers.Clear()
        lstLayerComplete.Clear()
        lstLayers.HideSelection = False
        'Disabling of the Edit and Delete buttons when the list of Layers is cleared
        SetEditDeleteEnabled()

        ' Sort parameters first so layers are in correct order
        clsBaseOperator.SortParameters()
        For Each clsTempParam In clsBaseOperator.clsParameters
            ' Note this relies on all layers having a function name starting with "geom_" or "stat_"
            ' If this is ever not the case then GetGeomName() needs to change.
            strTempGeomName = GetGeomName(clsTempParam)
            If strTempGeomName <> "" Then
                iMaxParameterPosition = Math.Max(iMaxParameterPosition, clsTempParam.Position)
                AddLayerToList(clsTempParam, strTempGeomName, bLayerComplete:=True)
            End If
        Next
    End Sub

    ' Enum for direction of movement
    Private Enum Direction
        Top
        Up
        Down
        Bottom
    End Enum

    ' Method to reorder ListView items and keep lstLayerComplete in sync
    Private Sub ReorderListViewItems(direction As Direction)
        If lstLayers.SelectedItems.Count = 0 Then Return

        Dim selectedIndex As Integer = lstLayers.SelectedIndices(0)
        Dim item As ListViewItem = lstLayers.SelectedItems(0)
        Dim layerComplete As Boolean = lstLayerComplete(selectedIndex)

        lstLayers.Items.RemoveAt(selectedIndex)
        lstLayerComplete.RemoveAt(selectedIndex)

        Dim newIndex As Integer = selectedIndex

        Select Case direction
            Case Direction.Top
                newIndex = 0
            Case Direction.Up
                newIndex = Math.Max(0, selectedIndex - 1)
            Case Direction.Down
                newIndex = Math.Min(lstLayers.Items.Count, selectedIndex + 1)
            Case Direction.Bottom
                newIndex = lstLayers.Items.Count
        End Select

        lstLayers.Items.Insert(newIndex, item)
        lstLayerComplete.Insert(newIndex, layerComplete)
        lstLayers.Items(newIndex).Selected = True
        lstLayers.Select()
    End Sub


    Private Sub cmdUp_Click(sender As Object, e As EventArgs) Handles cmdUp.Click
        ReorderListViewItems(Direction.Up)
    End Sub

    Private Sub cmdTop_Click(sender As Object, e As EventArgs) Handles cmdTop.Click
        ReorderListViewItems(Direction.Top)
    End Sub

    Private Sub cmdDown_Click(sender As Object, e As EventArgs) Handles cmdDown.Click
        ReorderListViewItems(Direction.Down)
    End Sub

    Private Sub cmdBottom_Click(sender As Object, e As EventArgs) Handles cmdBottom.Click
        ReorderListViewItems(Direction.Bottom)
    End Sub

    Private Sub AddLayerToList(clsGeomParameter As RParameter, strGeomName As String, bLayerComplete As Boolean)
        Dim lviLayer As ListViewItem
        Dim strLayerName As String

        iLayerIndex = iLayerIndex + 1
        strLayerName = iLayerIndex & "." & strGeomName
        lviLayer = New ListViewItem(text:=strLayerName)
        lviLayer.Tag = clsGeomParameter.strArgumentName
        lstLayers.Items.Add(lviLayer)
        lstLayerComplete.Add(bLayerComplete)

        If bLayerComplete Then
            lviLayer.ForeColor = Color.Green
        Else
            lviLayer.ForeColor = Color.Red
        End If

        'When the number of Layers in the lstLayers on ucrAdditionalLayers need to check if OK is enabled on dlgGeneralForGraphics.
        RaiseEvent NumberOfLayersChanged()
    End Sub

    Private Sub ucrAdditionalLayers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetEditDeleteEnabled()
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click, toolStripMenuItemGeomBar.Click, toolStripMenuItemGeomBoxPlot.Click, toolStripMenuItemGeomCol.Click, toolStripMenuItemGeomCount.Click, toolStripMenuItemGeomcategoricalmodel.Click,
            toolStripMenuItemGeomDensity.Click, toolStripMenuItemGeomJitter.Click, toolStripMenuItemGeomLabel.Click, toolStripMenuItemGeomparallelslopes.Click, toolStripMenuItemGeomtile.Click, toolStripMenuItemGeomcontour.Click, toolStripMenuItemGeomhistogram.Click,
            toolStripMenuItemGeomLabelRepel.Click, toolStripMenuItemGeomLine.Click, toolStripMenuItemGeomsmooth.Click, toolStripMenuItemGeomPoint.Click, toolStripMenuItemGeomRug.Click, toolStripMenuItemGeomText.Click, toolStripMenuItemGeomTextRepel.Click, toolStripMenuItemGeomDensityRidges.Click

        'setup the geom function to use
        Dim clsNewGeomFunction As New RFunction
        Dim strGeomRCommand As String = "geom_boxplot"
        Dim strPackage As String = "ggplot2"
        Dim bShowLayerSubdialog As Boolean = False

        If sender Is toolStripMenuItemGeomBoxPlot Then
            strGeomRCommand = "geom_boxplot"
        ElseIf sender Is toolStripMenuItemGeomBar Then
            strGeomRCommand = "geom_bar"
        ElseIf sender Is toolStripMenuItemGeomCount Then
            strGeomRCommand = "geom_count"
        ElseIf sender Is toolStripMenuItemGeomCol Then
            strGeomRCommand = "geom_col"
        ElseIf sender Is toolStripMenuItemGeomDensity Then
            strGeomRCommand = "geom_density"
        ElseIf sender Is toolStripMenuItemGeomtile Then
            strGeomRCommand = "geom_tile"
        ElseIf sender Is toolStripMenuItemGeomJitter Then
            strGeomRCommand = "geom_jitter"
        ElseIf sender Is toolStripMenuItemGeomhistogram Then
            strGeomRCommand = "geom_histogram"
        ElseIf sender Is toolStripMenuItemGeomcontour Then
            strGeomRCommand = "geom_contour"
        ElseIf sender Is toolStripMenuItemGeomDensityRidges Then
            strPackage = "ggridges"
            strGeomRCommand = "geom_density_ridges"
        ElseIf sender Is toolStripMenuItemGeomLabel Then
            strGeomRCommand = "geom_label"
        ElseIf sender Is toolStripMenuItemGeomLabelRepel Then
            strPackage = "ggrepel"
            strGeomRCommand = "geom_label_repel"
        ElseIf sender Is toolStripMenuItemGeomLine Then
            strGeomRCommand = "geom_line"
        ElseIf sender Is toolStripMenuItemGeomPoint Then
            strGeomRCommand = "geom_point"
        ElseIf sender Is toolStripMenuItemGeomRug Then
            strGeomRCommand = "geom_rug"
        ElseIf sender Is toolStripMenuItemGeomsmooth Then
            strGeomRCommand = "geom_smooth"
        ElseIf sender Is toolStripMenuItemGeomText Then
            strGeomRCommand = "geom_text"
        ElseIf sender Is toolStripMenuItemGeomTextRepel Then
            strPackage = "ggrepel"
            strGeomRCommand = "geom_text_repel"
        ElseIf sender Is toolStripMenuItemGeomcategoricalmodel Then
            strPackage = "moderndive"
            strGeomRCommand = "geom_categorical_model"
        ElseIf sender Is toolStripMenuItemGeomparallelslopes Then
            strPackage = "moderndive"
            strGeomRCommand = "geom_parallel_slopes"
        ElseIf sender Is cmdAdd Then
            bShowLayerSubdialog = True
        End If

        clsNewGeomFunction.SetPackageName(strPackage)
        clsNewGeomFunction.SetRCommand(strGeomRCommand)

        'if no specific geom command selected then show the layer subdialog for geom command selection
        If bShowLayerSubdialog Then
            sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsGgplotFunction,
                                   clsNewGeomFunc:=clsNewGeomFunction,
                                   clsNewGlobalAesFunc:=clsGlobalAesFunction,
                                   clsNewLocalAes:=GgplotDefaults.clsAesFunction,
                                   bFixGeom:=False,
                                   ucrNewBaseSelector:=Nothing,
                                   bApplyAesGlobally:=(bSetGlobalIsDefault AndAlso lstLayers.Items.Count = 0),
                                   iTabToDisplay:=0,
                                   strDataFrame:=strGlobalDataFrame)
            ParentForm.SendToBack()
            sdgLayerOptions.ShowDialog()
            'get the new options from the subdialog
            'todo. Should what should happen if a user clicks on Cancel in the sub dialog?
            strGlobalDataFrame = sdgLayerOptions.GetGlobalDataFrame()
            clsNewGeomFunction = sdgLayerOptions.clsGeomFunction.Clone()
        End If

        'incremnet the dialog parameter position to get unique argument name
        iMaxParameterPosition += 1

        'add the geom function as a new parameter of the dialog base operator
        Dim clsNewGeomParameter As New RParameter(clsNewGeomFunction.strRCommand & iMaxParameterPosition,
                                                  clsNewGeomFunction, iNewPosition:=iMaxParameterPosition)
        clsBaseOperator.AddParameter(clsNewGeomParameter)

        'add the parameter to the list of layers
        AddLayerToList(clsNewGeomParameter, clsNewGeomFunction.strRCommand, bLayerComplete:=sdgLayerOptions.TestForOKEnabled())
    End Sub

    Private Sub SetEditDeleteEnabled()
        If lstLayers.Items.Count > 0 AndAlso lstLayers.SelectedItems.Count = 1 Then
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

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If lstLayers.SelectedItems.Count = 1 Then
            If strMainDialogGeomNames Is Nothing OrElse Not strMainDialogGeomNames.Contains(lstLayers.SelectedItems(0).Tag) Then
                clsBaseOperator.RemoveParameterByName(lstLayers.SelectedItems(0).Tag)
                lstLayerComplete.RemoveAt(lstLayers.SelectedIndices(0))
                lstLayers.Items.Remove(lstLayers.SelectedItems(0))
                'When the number of Layers in the lstLayers on ucrAdditionalLayers need to check if OK is enabled on dlgGeneralForGraphics.
                RaiseEvent NumberOfLayersChanged()
            Else
                MsgBox("You cannot delete a layer that was created on the main dialog.", MsgBoxStyle.Information, "Cannot delete layer")
            End If
        End If
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        Dim clsSelectedGeomParameter As RParameter
        Dim clsSelectedGeomFunction As RFunction
        Dim clsLocalAes As RFunction

        clsSelectedGeomParameter = clsBaseOperator.GetParameter(lstLayers.SelectedItems(0).Tag)
        If clsSelectedGeomParameter IsNot Nothing Then
            clsSelectedGeomFunction = clsSelectedGeomParameter.clsArgumentCodeStructure
            If clsSelectedGeomFunction.ContainsParameter("mapping") Then
                clsLocalAes = clsSelectedGeomFunction.GetParameter("mapping").clsArgumentCodeStructure
            Else
                'TODO should come from ggplot defaults class
                clsLocalAes = New RFunction
                clsLocalAes.SetPackageName("ggplot2")
                clsLocalAes.SetRCommand("aes")
            End If

            'Warning: sdgLayerOptions should not be setup using dlgGeneralForGraphics' fields !! These fields should be given through to the ucrAdditionalLayers (which should have all these) 
            sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsGgplotFunction, clsNewGeomFunc:=clsSelectedGeomFunction, clsNewGlobalAesFunc:=clsGlobalAesFunction, clsNewLocalAes:=clsLocalAes, bFixGeom:=True, strDataFrame:=strGlobalDataFrame, bApplyAesGlobally:=False, bReset:=True, iTabToDisplay:=0)
            'It has been chosen to fix the value of bApplyAesGlobally to False as when a Layer is editted, the choice to apply the Aes globally should be reconsidered no matter what it has been during last edit.
            ParentForm.SendToBack() 'Otherwise sdgLayerOptions appears behind sdgPLotOptions
            sdgLayerOptions.ShowDialog()

            clsSelectedGeomFunction = sdgLayerOptions.clsGeomFunction.Clone()
            clsSelectedGeomParameter.SetArgument(clsSelectedGeomFunction)
        Else
            MsgBox("Could not find layer. Delete the layer and recreate it.", MsgBoxStyle.Information, "Cannot find layer")
        End If
    End Sub

    Private Function GetGeomName(clsParam As RParameter) As String
        Dim clsTempFunc As RFunction
        Dim strGeom As String = ""

        If clsParam IsNot Nothing AndAlso clsParam.bIsFunction AndAlso clsParam.clsArgumentCodeStructure IsNot Nothing Then
            clsTempFunc = TryCast(clsParam.clsArgumentCodeStructure, RFunction)
            If clsTempFunc IsNot Nothing Then
                If clsTempFunc.strRCommand.StartsWith("geom_") OrElse clsTempFunc.strRCommand.StartsWith("stat_") Then
                    strGeom = clsTempFunc.strRCommand
                End If
            End If
        End If
        Return strGeom
    End Function


    Private Sub cmdgoUp_Click(sender As Object, e As EventArgs) Handles cmdUp.Click
        ReorderListViewItems(Direction.Up)
    End Sub

    Private Sub cmdgoTop_Click(sender As Object, e As EventArgs) Handles cmdTop.Click
        ReorderListViewItems(Direction.Top)
    End Sub

    Private Sub cmdgoDown_Click(sender As Object, e As EventArgs) Handles cmdDown.Click
        ReorderListViewItems(Direction.Down)
    End Sub

    Private Sub cmdgoBottom_Click(sender As Object, e As EventArgs) Handles cmdBottom.Click
        ReorderListViewItems(Direction.Bottom)
    End Sub
End Class