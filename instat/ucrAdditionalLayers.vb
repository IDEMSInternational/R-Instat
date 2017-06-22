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
    Public clsBaseOperator As ROperator
    'clsRSyntax is playing the role of "+" operator in the construction of the whole ggplot2 command. It will take as first parameter clsRggplotFunction and as other parameters the sdgLayerOptions.clsGeomFunction's of different layers.
    Public clsRggplotFunction As RFunction
    Public clsGgplotAesFunction As RFunction
    'clsRggplotFunction is the global ggplot function that takes as mapping parameter clsGgplotAesFunction. clsRggplotFunction is linked through to sdgLayerOptions where it might be modified when sdgLayerOptions.chkApplyOnAllLyers is ticked for instance.
    Public bFirstLoad As Boolean = True
    Public bReset As Boolean = True
    Public lstLayerComplete As New List(Of Boolean)
    Public iLayerIndex As Integer
    Private strGlobalDataFrame As String
    Public bSetGlobalIsDefault As Boolean
    'Deciding if the first layer needs to be used for global aesthetics. 
    'Question to be discussed: What is this variable about again ? it is linked with sdgPlots.bAdditionalLayersSetGlobal in sdgPLots.bLayersDefaultIsGolobal.
    Public Event NumberOfLayersChanged() 'This event is raised when the number of Layers in the lstLayers on ucrAdditionalLayers has been changed, then handled by testOkEnabled On GeneralForGraphics. 

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub SetBaseOperator(clsNewBaseOperator As ROperator)
        clsBaseOperator = clsNewBaseOperator
    End Sub

    Public Sub SetGGplotFunction(clsRggplotFunc As RFunction)
        clsRggplotFunction = clsRggplotFunc
    End Sub

    Public Sub SetAesFunction(clsAesFunc As RFunction)
        clsGgplotAesFunction = clsAesFunc
    End Sub

    Public Sub SetRCodeForControl(Optional clsNewBaseOperator As ROperator = Nothing, Optional clsRNewggplotFunc As RFunction = Nothing, Optional clsNewAesFunc As RFunction = Nothing, Optional bReset As Boolean = False)
        clsBaseOperator = clsNewBaseOperator
        clsGgplotAesFunction = clsNewAesFunc
        clsRggplotFunction = clsRNewggplotFunc
    End Sub

    Private Sub ucrAdditionalLayers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
            bReset = False
        End If
    End Sub

    Private Sub SetDefaults()
        iLayerIndex = 0
        lstLayers.Clear()
        lstLayerComplete.Clear()
        strGlobalDataFrame = ""
        bSetGlobalIsDefault = True
        'Task: potentially get rid of this when the sdgPlotOptions has been reviewed to make the first Layer to be the main Layer. Then the procedure to tick the Apply on all Layers should simply be: if First first Layer, then tick by default, otherwise untick by default.
        SetEditDeleteEnabled()
    End Sub

    Private Sub InitialiseControl()

    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim clsNewLocalAesFunction As New RFunction
        Dim clsNewGeomFunction As New RFunction

        'TODO add these in Ggplot default class
        clsNewLocalAesFunction.SetPackageName("ggplot2")
        clsNewLocalAesFunction.SetRCommand("aes")
        clsNewGeomFunction.SetPackageName("ggplot2")
        clsNewGeomFunction.SetRCommand("geom_boxplot")

        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsNewGeomFunction, clsNewGlobalAesFunc:=clsGgplotAesFunction, clsNewLocalAes:=clsNewLocalAesFunction, bFixGeom:=False, ucrNewBaseSelector:=Nothing, bApplyAesGlobally:=(bSetGlobalIsDefault AndAlso lstLayers.Items.Count = 0), iTabToDisplay:=0, strDataframe:=strGlobalDataFrame)
        ParentForm.SendToBack()
        sdgLayerOptions.ShowDialog()
        strGlobalDataFrame = sdgLayerOptions.GetGlobalDataFrame()
        AddLayers(clsNewGeomFunction.strRCommand)
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

    Public Sub AddLayers(strGeomName As String, Optional lviCurrentItem As ListViewItem = Nothing)
        Dim lviLayer As ListViewItem
        Dim strLayerName As String

        If lviCurrentItem Is Nothing Then
            iLayerIndex = iLayerIndex + 1
            strLayerName = iLayerIndex & "." & strGeomName
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

        clsBaseOperator.AddParameter(strParameterName:=strLayerName, clsRFunctionParameter:=sdgLayerOptions.clsGeomFunction.Clone(), iPosition:=iLayerIndex)
        'Note: as the GeomFunction on sdgLayerOptions will be edited for different layers, it cannot be linked like clsGgplotFunction would, it needs to be cloned.

        'When the number of Layers in the lstLayers on ucrAdditionalLayers need to check if OK is enabled on dlgGeneralForGraphics.
        RaiseEvent NumberOfLayersChanged()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If lstLayers.SelectedItems.Count = 1 Then
            clsBaseOperator.RemoveParameterByName(lstLayers.SelectedItems(0).Text)
            lstLayerComplete.RemoveAt(lstLayers.SelectedIndices(0))
            lstLayers.Items.Remove(lstLayers.SelectedItems(0))

            'When the number of Layers in the lstLayers on ucrAdditionalLayers need to check if OK is enabled on dlgGeneralForGraphics.
            RaiseEvent NumberOfLayersChanged()
        End If
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        Dim clsSelectedGeomFunction As RFunction
        Dim clsLocalAes As RFunction

        'The selected geom is found as the RFunction of the appropriate RParameter of RSyntax. The name of that Parameter is the name of the selected item in the lstLayers. That one is fetched using .SelectedItems(0) as there can only be one selected item at a time when the edit button is clicked.
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
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsSelectedGeomFunction, clsNewGlobalAesFunc:=clsGgplotAesFunction, clsNewLocalAes:=clsLocalAes, bFixGeom:=True, strDataframe:=strGlobalDataFrame, bApplyAesGlobally:=False, bReset:=False, iTabToDisplay:=0)
        'It has been chosen to fix the value of bApplyAesGlobally to False as when a Layer is editted, the choice to apply the Aes globally should be reconsidered no matter what it has been during last edit.
        ParentForm.SendToBack() 'Otherwise sdgLayerOptions appears behind sdgPLotOptions
        sdgLayerOptions.ShowDialog()
        AddLayers(clsSelectedGeomFunction.strRCommand, lstLayers.SelectedItems(0))
    End Sub

    Public Sub Reset()
        SetDefaults()
    End Sub
End Class
