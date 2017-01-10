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
    Public clsRggplotFunction As New RFunction
    Private bFirstLoad As Boolean = True
    Private lstLayerComplete As New List(Of Boolean)
    'list of completed layers.
    Private iLayerIndex As Integer
    'current layer
    Public WithEvents clsGgplotAesFunction As New RFunction
    Private strGlobalDataFrame As String
    Public bDataFrameSet As Boolean

    Private Sub dlgGeneralForGraphics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        'setting the base ggplot functions
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsGgplotAesFunction.SetRCommand("aes")
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)
        'True for "we are setting the first parameter, on the left of +".
        ucrBase.iHelpTopicID = 356

        ucrSaveGraph.SetDataFrameSelector(sdgLayerOptions.ucrGeomWithAes.ucrGeomWithAesSelector.ucrAvailableDataFrames)
        ucrSaveGraph.strPrefix = "Graph"
        ucrAdditionalLayers.SetRSyntax(ucrBase.clsRsyntax)
        ucrAdditionalLayers.SetGGplotFunction(clsRggplotFunction)
        ucrAdditionalLayers.SetAesFunction(clsGgplotAesFunction)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        'By default, we want to put in the script the output of our Base R-command (in this case the ...+...+...) even when it has been assigned to some object (in which case we want the name of that object in the script so that it's called when the script is run).
        'For example, when a graph is saved, it is assigned to it's place in an R-instat object. If we had set bExcludeAssignedFunctionOutput to True, then we would never print the graph when running the script.
        ucrBase.clsRsyntax.iCallType = 3
        'iCalltype 3 corresponds to single graphics display in output window.
    End Sub

    Private Sub SetDefaults()
        iLayerIndex = 0
        'lstLayers.Clear()
        lstLayerComplete.Clear()
        'SetEditDeleteEnabled()
        strGlobalDataFrame = ""
        bDataFrameSet = False
        clsRggplotFunction.ClearParameters()
        clsGgplotAesFunction.ClearParameters()
        ucrAdditionalLayers.Reset()
        If ucrBase.clsRsyntax.clsBaseOperator IsNot Nothing Then
            ucrBase.clsRsyntax.clsBaseOperator.RemoveAllAdditionalParameters()
        End If
        sdgPlots.Reset()
        'Warning/to be discussed: sdgPlots doesn't work like sdgLayerOptions. Information actually stays on the dialogue, as it cannot be editted on the general for graphics (yet) I think that sdgPlots should work like LayerOptions and be filled in at load, thanks to a setup function and setsettings sub. 
        TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    'Private Sub cmdAdd_Click(sender As Object, e As EventArgs)
    '    sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=Nothing, clsTempAesFunc:=clsGgplotAesFunction, bFixAes:=False, bFixGeom:=False, strDataframe:=strGlobalDataFrame, bApplyAesGlobally:=lstLayers.Items.Count = 0, bIgnoreGlobalAes:=False)
    '    sdgLayerOptions.ShowDialog()
    '    strGlobalDataFrame = sdgLayerOptions.strGlobalDataFrame
    '    AddLayers()
    'End Sub

    'Public Sub AddLayers(Optional lviCurrentItem As ListViewItem = Nothing)
    '    Dim lviLayer As ListViewItem
    '    Dim strLayerName As String

    '    If lviCurrentItem Is Nothing Then
    '        iLayerIndex = iLayerIndex + 1
    '        strLayerName = iLayerIndex & "." & sdgLayerOptions.ucrGeomWithAes.cboGeomList.SelectedItem
    '        lviLayer = New ListViewItem(text:=strLayerName)
    '        lstLayers.Items.Add(lviLayer)
    '        lstLayerComplete.Add(sdgLayerOptions.TestForOKEnabled())
    '    Else
    '        lviLayer = lviCurrentItem
    '        lstLayerComplete(lstLayers.Items.IndexOf(lviLayer)) = sdgLayerOptions.TestForOKEnabled()
    '        strLayerName = lviCurrentItem.Text
    '    End If

    '    If sdgLayerOptions.TestForOKEnabled() Then
    '        lstLayers.Items(lstLayers.Items.IndexOf(lviLayer)).ForeColor = Color.Green
    '    Else
    '        lstLayers.Items(lstLayers.Items.IndexOf(lviLayer)).ForeColor = Color.Red
    '    End If
    '    ucrBase.clsRsyntax.SetOperatorParameter(False, strParameterName:=strLayerName, clsRFunc:=sdgLayerOptions.clsGeomFunction.Clone())
    '    TestOKEnabled()
    'End Sub

    Public Sub TestOKEnabled()
        Dim bTemp As Boolean = False
        For Each bTemp In ucrAdditionalLayers.lstLayerComplete
            If Not bTemp Then
                Exit For
            End If
        Next
        ucrBase.OKEnabled(bTemp)
    End Sub

    'Private Sub cmdDelete_Click(sender As Object, e As EventArgs)
    '    If lstLayers.SelectedItems.Count = 1 Then
    '        ucrBase.clsRsyntax.RemoveOperatorParameter(lstLayers.SelectedItems(0).Text)
    '        lstLayerComplete.RemoveAt(lstLayers.SelectedIndices(0))
    '        lstLayers.Items.Remove(lstLayers.SelectedItems(0))
    '    End If
    '    TestOKEnabled()
    'End Sub

    'Private Sub lstLayers_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    SetEditDeleteEnabled()
    'End Sub

    'Private Sub SetEditDeleteEnabled()
    '    If lstLayers.SelectedItems.Count = 1 Then
    '        cmdDelete.Enabled = True
    '        cmdEdit.Enabled = True
    '    Else
    '        cmdDelete.Enabled = False
    '        cmdEdit.Enabled = False
    '    End If
    'End Sub

    'Private Sub cmdEdit_Click(sender As Object, e As EventArgs)
    '    Dim clsSelectedGeom As RFunction
    '    Dim clsLocalAes As RFunction

    '    clsSelectedGeom = ucrBase.clsRsyntax.GetParameter(lstLayers.SelectedItems(0).Text).clsArgumentFunction
    '    If clsSelectedGeom.GetParameter("mapping") IsNot Nothing Then
    '        clsLocalAes = clsSelectedGeom.GetParameter("mapping").clsArgumentFunction
    '    Else
    '        clsLocalAes = Nothing
    '    End If
    '    sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=clsSelectedGeom, clsTempAesFunc:=clsGgplotAesFunction, bFixAes:=False, bFixGeom:=True, strDataframe:=strGlobalDataFrame, bApplyAesGlobally:=False, bIgnoreGlobalAes:=False, clsTempLocalAes:=clsLocalAes)
    '    sdgLayerOptions.ShowDialog()
    '    AddLayers(lstLayers.SelectedItems(0))
    'End Sub

    Private Sub ucrSaveGraph_GraphNameChanged() Handles ucrSaveGraph.GraphNameChanged, ucrSaveGraph.SaveGraphCheckedChanged
        'Warning/Task: this method seems weird to me, why do we get the dataframe from sdgLayerOptions ???!
        If ucrSaveGraph.bSaveGraph Then
            ucrBase.clsRsyntax.SetAssignTo(ucrSaveGraph.strGraphName, strTempDataframe:=sdgLayerOptions.ucrGeomWithAes.ucrGeomWithAesSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=ucrSaveGraph.strGraphName)
        Else
            ucrBase.clsRsyntax.SetAssignTo("last_graph", strTempDataframe:=sdgLayerOptions.ucrGeomWithAes.ucrGeomWithAesSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        End If
    End Sub

    Private Sub SetupPlotOptions() 'Warning to be discussed: I m hoping to have a Setup function in sdgPlots itself... ?
        sdgPlots.SetRSyntax(ucrBase.clsRsyntax)
        sdgPlots.SetGgplotFunction(clsRggplotFunction)
    End Sub
    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.DisableLayersTab()
        SetupPlotOptions()
        sdgPlots.ShowDialog()
        sdgPlots.EnableLayersTab()
    End Sub

    Private Sub ucrAdditionalLayers_NumberOfLayersChanged() Handles ucrAdditionalLayers.NumberOfLayersChanged
        'When the number of Layers in the lstLayers on ucrAdditionalLayers need to check if OK is enabled on dlgGeneralForGraphics.
        TestOKEnabled()
    End Sub

    'Private Sub DisplayGraphInOutputWindow_When_ClickOK(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
    'Dim clsSaveFunction As New RFunction
    'Dim clsDeleteFunction As New RFunction
    'Dim strImageLocation As String
    'clsSaveFunction.SetRCommand("ggsave")
    'If file R_Instat_Temp__Graphs is not there, create it... Where do we do this ? In setup method ? For the moment it's on frmMain Load
    'frmMain.clsRLink.rtbOutput.CreateTempDirectory()
    'Need to add ggsave as a Secondary RCommand on every grph dialogue.
    'Need to edit RMethods producing ggplots to always ggsave in that file as well... Need to find a smart way to name things.
    'strImageLocation = IO.Path.GetTempPath() & "R_Instat_Temp_Graphs/" & ucrSaveGraph.strGraphName & ".jpg"
    'clsSaveFunction.AddParameter("filename", Chr(34) & strImageLocation.Replace("\", "/") & Chr(34))
    'frmMain.clsRLink.RunScript(clsSaveFunction.ToScript(), strComment:="Temporarily saving the image of the last ggplot grph in the temp directory R_Instat_Temp_Graphs.")
    'frmMain.clsRLink.rtbOutput.DisplayGraph(strImageLocation)
    'clsDeleteFunction.SetRCommand("unlink")
    'clsDeleteFunction.AddParameter(strParameterName:="FileName", strParameterValue:=Chr(34) & strImageLocation.Replace("\", "/") & Chr(34), bIncludeArgumentName:=False)
    'frmMain.clsRLink.RunScript(clsDeleteFunction.ToScript(), strComment:="Deleting graph file from the temp file.")
    'End Sub
End Class