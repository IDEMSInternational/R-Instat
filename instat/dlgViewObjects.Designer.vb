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
Partial Class dlgViewObjects
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgViewObjects))
        Me.lblSelectedObject = New System.Windows.Forms.Label()
        Me.rdoStructure = New System.Windows.Forms.RadioButton()
        Me.rdoAllContents = New System.Windows.Forms.RadioButton()
        Me.rdoComponent = New System.Windows.Forms.RadioButton()
        Me.rdoViewGraph = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverSelectedObject = New instat.ucrReceiverSingle()
        Me.ucrSelectorForViewObject = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlContentsToView = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'lblSelectedObject
        '
        resources.ApplyResources(Me.lblSelectedObject, "lblSelectedObject")
        Me.lblSelectedObject.Name = "lblSelectedObject"
        '
        'rdoStructure
        '
        resources.ApplyResources(Me.rdoStructure, "rdoStructure")
        Me.rdoStructure.Name = "rdoStructure"
        Me.rdoStructure.TabStop = True
        Me.rdoStructure.Tag = "Structure"
        Me.rdoStructure.UseVisualStyleBackColor = True
        '
        'rdoAllContents
        '
        resources.ApplyResources(Me.rdoAllContents, "rdoAllContents")
        Me.rdoAllContents.Name = "rdoAllContents"
        Me.rdoAllContents.TabStop = True
        Me.rdoAllContents.Tag = "All_Contents"
        Me.rdoAllContents.UseVisualStyleBackColor = True
        '
        'rdoComponent
        '
        resources.ApplyResources(Me.rdoComponent, "rdoComponent")
        Me.rdoComponent.Name = "rdoComponent"
        Me.rdoComponent.TabStop = True
        Me.rdoComponent.Tag = "Component"
        Me.rdoComponent.UseVisualStyleBackColor = True
        '
        'rdoViewGraph
        '
        resources.ApplyResources(Me.rdoViewGraph, "rdoViewGraph")
        Me.rdoViewGraph.Name = "rdoViewGraph"
        Me.rdoViewGraph.TabStop = True
        Me.rdoViewGraph.UseVisualStyleBackColor = True
        '
        'ucrReceiverSelectedObject
        '
        Me.ucrReceiverSelectedObject.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverSelectedObject, "ucrReceiverSelectedObject")
        Me.ucrReceiverSelectedObject.Name = "ucrReceiverSelectedObject"
        Me.ucrReceiverSelectedObject.Selector = Nothing
        Me.ucrReceiverSelectedObject.strNcFilePath = ""
        Me.ucrReceiverSelectedObject.ucrSelector = Nothing
        '
        'ucrSelectorForViewObject
        '
        Me.ucrSelectorForViewObject.bShowHiddenColumns = False
        Me.ucrSelectorForViewObject.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForViewObject, "ucrSelectorForViewObject")
        Me.ucrSelectorForViewObject.Name = "ucrSelectorForViewObject"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrPnlContentsToView
        '
        resources.ApplyResources(Me.ucrPnlContentsToView, "ucrPnlContentsToView")
        Me.ucrPnlContentsToView.Name = "ucrPnlContentsToView"
        '
        'dlgViewObjects
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rdoViewGraph)
        Me.Controls.Add(Me.rdoComponent)
        Me.Controls.Add(Me.rdoAllContents)
        Me.Controls.Add(Me.rdoStructure)
        Me.Controls.Add(Me.ucrReceiverSelectedObject)
        Me.Controls.Add(Me.lblSelectedObject)
        Me.Controls.Add(Me.ucrSelectorForViewObject)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlContentsToView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgViewObjects"
        Me.Tag = ""
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForViewObject As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblSelectedObject As Label
    Friend WithEvents ucrReceiverSelectedObject As ucrReceiverSingle
    Friend WithEvents rdoStructure As RadioButton
    Friend WithEvents rdoAllContents As RadioButton
    Friend WithEvents rdoComponent As RadioButton
    Friend WithEvents rdoViewGraph As RadioButton
    Friend WithEvents ucrPnlContentsToView As UcrPanel
End Class
