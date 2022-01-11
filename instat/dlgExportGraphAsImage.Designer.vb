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
        Me.lblSelectedGraph.AutoSize = True
        Me.lblSelectedGraph.Location = New System.Drawing.Point(264, 45)
        Me.lblSelectedGraph.Name = "lblSelectedGraph"
        Me.lblSelectedGraph.Size = New System.Drawing.Size(84, 13)
        Me.lblSelectedGraph.TabIndex = 1
        Me.lblSelectedGraph.Text = "Selected Graph:"
        '
        'ucrSelectedGraphReceiver
        '
        Me.ucrSelectedGraphReceiver.AutoSize = True
        Me.ucrSelectedGraphReceiver.frmParent = Me
        Me.ucrSelectedGraphReceiver.Location = New System.Drawing.Point(265, 60)
        Me.ucrSelectedGraphReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectedGraphReceiver.Name = "ucrSelectedGraphReceiver"
        Me.ucrSelectedGraphReceiver.Selector = Nothing
        Me.ucrSelectedGraphReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrSelectedGraphReceiver.strNcFilePath = ""
        Me.ucrSelectedGraphReceiver.TabIndex = 2
        Me.ucrSelectedGraphReceiver.ucrSelector = Nothing
        '
        'ucrSelectorGraphAsImage
        '
        Me.ucrSelectorGraphAsImage.AutoSize = True
        Me.ucrSelectorGraphAsImage.bDropUnusedFilterLevels = False
        Me.ucrSelectorGraphAsImage.bShowHiddenColumns = False
        Me.ucrSelectorGraphAsImage.bUseCurrentFilter = True
        Me.ucrSelectorGraphAsImage.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorGraphAsImage.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorGraphAsImage.Name = "ucrSelectorGraphAsImage"
        Me.ucrSelectorGraphAsImage.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorGraphAsImage.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 224)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(404, 52)
        Me.ucrBase.TabIndex = 6
        '
        'ucrFilePath
        '
        Me.ucrFilePath.AutoSize = True
        Me.ucrFilePath.DefaultFileSuggestionName = ""
        Me.ucrFilePath.FilePath = ""
        Me.ucrFilePath.FilePathBrowseText = resources.GetString("ucrFilePath.FilePathBrowseText")
        Me.ucrFilePath.FilePathDialogFilter = "JPEG (*.jpeg)|*.jpeg|PNG(*.png)|*.png|BitMaP(*.bmp)|*.bmp|EPS(*.eps)|*.eps|PostSc" &
    "ript(*.ps)|*.ps|SVG(*.svg)|*.svg|WMF(*.wmf)|*.wmf|PDF(*.pdf)|*.pdf"
        Me.ucrFilePath.FilePathDialogTitle = "Save Graph As Image"
        Me.ucrFilePath.FilePathLabel = resources.GetString("ucrFilePath.FilePathLabel")
        Me.ucrFilePath.FolderBrowse = False
        Me.ucrFilePath.Location = New System.Drawing.Point(14, 195)
        Me.ucrFilePath.Name = "ucrFilePath"
        Me.ucrFilePath.SelectedFileFilterIndex = 1
        Me.ucrFilePath.Size = New System.Drawing.Size(990, 34)
        Me.ucrFilePath.TabIndex = 7
        '
        'dlgExportGraphAsImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(418, 280)
        Me.Controls.Add(Me.ucrFilePath)
        Me.Controls.Add(Me.lblSelectedGraph)
        Me.Controls.Add(Me.ucrSelectedGraphReceiver)
        Me.Controls.Add(Me.ucrSelectorGraphAsImage)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExportGraphAsImage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export Graph As Image"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorGraphAsImage As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSelectedGraphReceiver As ucrReceiverSingle
    Friend WithEvents lblSelectedGraph As Label
    Friend WithEvents ucrFilePath As ucrFilePath
End Class
