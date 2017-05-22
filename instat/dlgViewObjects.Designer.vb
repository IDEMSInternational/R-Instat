﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.lblSelectedObject.Location = New System.Drawing.Point(250, 43)
        Me.lblSelectedObject.Name = "lblSelectedObject"
        Me.lblSelectedObject.Size = New System.Drawing.Size(100, 23)
        Me.lblSelectedObject.TabIndex = 1
        Me.lblSelectedObject.Text = "Object to View:"
        '
        'rdoStructure
        '
        Me.rdoStructure.Location = New System.Drawing.Point(10, 206)
        Me.rdoStructure.Name = "rdoStructure"
        Me.rdoStructure.Size = New System.Drawing.Size(88, 24)
        Me.rdoStructure.TabIndex = 4
        Me.rdoStructure.TabStop = True
        Me.rdoStructure.Tag = "Structure"
        Me.rdoStructure.Text = "Structure"
        Me.rdoStructure.UseVisualStyleBackColor = True
        '
        'rdoAllContents
        '
        Me.rdoAllContents.Location = New System.Drawing.Point(104, 206)
        Me.rdoAllContents.Name = "rdoAllContents"
        Me.rdoAllContents.Size = New System.Drawing.Size(100, 24)
        Me.rdoAllContents.TabIndex = 5
        Me.rdoAllContents.TabStop = True
        Me.rdoAllContents.Tag = "All_Contents"
        Me.rdoAllContents.Text = "All Contents"
        Me.rdoAllContents.UseVisualStyleBackColor = True
        '
        'rdoComponent
        '
        Me.rdoComponent.Location = New System.Drawing.Point(198, 206)
        Me.rdoComponent.Name = "rdoComponent"
        Me.rdoComponent.Size = New System.Drawing.Size(87, 24)
        Me.rdoComponent.TabIndex = 6
        Me.rdoComponent.TabStop = True
        Me.rdoComponent.Tag = "Component"
        Me.rdoComponent.Text = "Component"
        Me.rdoComponent.UseVisualStyleBackColor = True
        '
        'rdoViewGraph
        '
        Me.rdoViewGraph.Location = New System.Drawing.Point(292, 206)
        Me.rdoViewGraph.Name = "rdoViewGraph"
        Me.rdoViewGraph.Size = New System.Drawing.Size(80, 24)
        Me.rdoViewGraph.TabIndex = 7
        Me.rdoViewGraph.TabStop = True
        Me.rdoViewGraph.Text = "View Graph"
        Me.rdoViewGraph.UseVisualStyleBackColor = True
        '
        'ucrReceiverSelectedObject
        '
        Me.ucrReceiverSelectedObject.frmParent = Me
        Me.ucrReceiverSelectedObject.Location = New System.Drawing.Point(250, 60)
        Me.ucrReceiverSelectedObject.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSelectedObject.Name = "ucrReceiverSelectedObject"
        Me.ucrReceiverSelectedObject.Selector = Nothing
        Me.ucrReceiverSelectedObject.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSelectedObject.TabIndex = 2
        '
        'ucrSelectorForViewObject
        '
        Me.ucrSelectorForViewObject.bShowHiddenColumns = False
        Me.ucrSelectorForViewObject.bUseCurrentFilter = True
        Me.ucrSelectorForViewObject.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForViewObject.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForViewObject.Name = "ucrSelectorForViewObject"
        Me.ucrSelectorForViewObject.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForViewObject.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 244)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 8
        '
        'ucrPnlContentsToView
        '
        Me.ucrPnlContentsToView.Location = New System.Drawing.Point(4, 193)
        Me.ucrPnlContentsToView.Name = "ucrPnlContentsToView"
        Me.ucrPnlContentsToView.Size = New System.Drawing.Size(416, 45)
        Me.ucrPnlContentsToView.TabIndex = 3
        '
        'dlgViewDescriptives
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 301)
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
        Me.Name = "dlgViewDescriptives"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "View Object"
        Me.ResumeLayout(False)

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
