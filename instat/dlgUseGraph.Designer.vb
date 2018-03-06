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
Partial Class dlgUseGraph
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgUseGraph))
        Me.lblGraphtoUse = New System.Windows.Forms.Label()
        Me.cmdPlotOptions = New System.Windows.Forms.Button()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrGraphReceiver = New instat.ucrReceiverSingle()
        Me.ucrGraphsSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblGraphtoUse
        '
        resources.ApplyResources(Me.lblGraphtoUse, "lblGraphtoUse")
        Me.lblGraphtoUse.Name = "lblGraphtoUse"
        '
        'cmdPlotOptions
        '
        resources.ApplyResources(Me.cmdPlotOptions, "cmdPlotOptions")
        Me.cmdPlotOptions.Name = "cmdPlotOptions"
        Me.cmdPlotOptions.UseVisualStyleBackColor = True
        '
        'ucrSaveGraph
        '
        resources.ApplyResources(Me.ucrSaveGraph, "ucrSaveGraph")
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        '
        'ucrGraphReceiver
        '
        Me.ucrGraphReceiver.frmParent = Me
        resources.ApplyResources(Me.ucrGraphReceiver, "ucrGraphReceiver")
        Me.ucrGraphReceiver.Name = "ucrGraphReceiver"
        Me.ucrGraphReceiver.Selector = Nothing
        Me.ucrGraphReceiver.strNcFilePath = ""
        Me.ucrGraphReceiver.ucrSelector = Nothing
        '
        'ucrGraphsSelector
        '
        Me.ucrGraphsSelector.bShowHiddenColumns = False
        Me.ucrGraphsSelector.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrGraphsSelector, "ucrGraphsSelector")
        Me.ucrGraphsSelector.Name = "ucrGraphsSelector"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgUseGraph
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.cmdPlotOptions)
        Me.Controls.Add(Me.lblGraphtoUse)
        Me.Controls.Add(Me.ucrGraphReceiver)
        Me.Controls.Add(Me.ucrGraphsSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgUseGraph"
        Me.Tag = "Use_Graph"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrGraphsSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrGraphReceiver As ucrReceiverSingle
    Friend WithEvents lblGraphtoUse As Label
    Friend WithEvents cmdPlotOptions As Button
    Friend WithEvents ucrSaveGraph As ucrSave
End Class
