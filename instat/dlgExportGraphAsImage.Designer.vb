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

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgExportGraphAsImage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgExportGraphAsImage))
        Me.lblSelectedGraph = New System.Windows.Forms.Label()
        Me.ucrSelectedGraphReceiver = New instat.ucrReceiverSingle()
        Me.ucrSelectorGraphAsImage = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrFilePath = New instat.ucrFilePath()
        Me.SuspendLayout()
        '
        'lblSelectedGraph
        '
        resources.ApplyResources(Me.lblSelectedGraph, "lblSelectedGraph")
        Me.lblSelectedGraph.Name = "lblSelectedGraph"
        '
        'ucrSelectedGraphReceiver
        '
        Me.ucrSelectedGraphReceiver.frmParent = Me
        resources.ApplyResources(Me.ucrSelectedGraphReceiver, "ucrSelectedGraphReceiver")
        Me.ucrSelectedGraphReceiver.Name = "ucrSelectedGraphReceiver"
        Me.ucrSelectedGraphReceiver.Selector = Nothing
        Me.ucrSelectedGraphReceiver.strNcFilePath = ""
        Me.ucrSelectedGraphReceiver.ucrSelector = Nothing
        '
        'ucrSelectorGraphAsImage
        '
        Me.ucrSelectorGraphAsImage.bDropUnusedFilterLevels = False
        Me.ucrSelectorGraphAsImage.bShowHiddenColumns = False
        Me.ucrSelectorGraphAsImage.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorGraphAsImage, "ucrSelectorGraphAsImage")
        Me.ucrSelectorGraphAsImage.Name = "ucrSelectorGraphAsImage"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrFilePath
        '
        Me.ucrFilePath.DefaultFileSuggestionName = ""
        Me.ucrFilePath.FilePath = ""
        Me.ucrFilePath.FilePathBrowseText = "Browse"
        Me.ucrFilePath.FilePathDialogFilter = "JPEG (*.jpeg)|*.jpeg|PNG(*.png)|*.png|BitMaP(*.bmp)|*.bmp|EPS(*.eps)|*.eps|PostSc" &
    "ript(*.ps)|*.ps|SVG(*.svg)|*.svg|WMF(*.wmf)|*.wmf|PDF(*.pdf)|*.pdf"
        Me.ucrFilePath.FilePathDialogTitle = "Save Graph As Image"
        Me.ucrFilePath.FilePathLabel = "Export File:"
        resources.ApplyResources(Me.ucrFilePath, "ucrFilePath")
        Me.ucrFilePath.Name = "ucrFilePath"
        '
        'dlgExportGraphAsImage
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrFilePath)
        Me.Controls.Add(Me.lblSelectedGraph)
        Me.Controls.Add(Me.ucrSelectedGraphReceiver)
        Me.Controls.Add(Me.ucrSelectorGraphAsImage)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExportGraphAsImage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorGraphAsImage As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSelectedGraphReceiver As ucrReceiverSingle
    Friend WithEvents lblSelectedGraph As Label
    Friend WithEvents ucrFilePath As ucrFilePath
End Class
