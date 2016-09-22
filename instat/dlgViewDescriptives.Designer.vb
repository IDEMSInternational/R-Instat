<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgViewDescriptives
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorForViewObject = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblSelectedObject = New System.Windows.Forms.Label()
        Me.ucrReceiverSelectedObject = New instat.ucrReceiverSingle()
        Me.rdoStructure = New System.Windows.Forms.RadioButton()
        Me.rdoAllContents = New System.Windows.Forms.RadioButton()
        Me.rdoComponent = New System.Windows.Forms.RadioButton()
        Me.rdoViewGraph = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 244)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 7
        '
        'ucrSelectorForViewObject
        '
        Me.ucrSelectorForViewObject.bShowHiddenColumns = False
        Me.ucrSelectorForViewObject.bUseCurrentFilter = False
        Me.ucrSelectorForViewObject.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForViewObject.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForViewObject.Name = "ucrSelectorForViewObject"
        Me.ucrSelectorForViewObject.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForViewObject.TabIndex = 6
        '
        'lblSelectedObject
        '
        Me.lblSelectedObject.Location = New System.Drawing.Point(249, 43)
        Me.lblSelectedObject.Name = "lblSelectedObject"
        Me.lblSelectedObject.Size = New System.Drawing.Size(100, 23)
        Me.lblSelectedObject.TabIndex = 5
        Me.lblSelectedObject.Text = "Selected Object:"
        '
        'ucrReceiverSelectedObject
        '
        Me.ucrReceiverSelectedObject.Location = New System.Drawing.Point(250, 60)
        Me.ucrReceiverSelectedObject.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSelectedObject.Name = "ucrReceiverSelectedObject"
        Me.ucrReceiverSelectedObject.Selector = Nothing
        Me.ucrReceiverSelectedObject.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSelectedObject.TabIndex = 4
        '
        'rdoStructure
        '
        Me.rdoStructure.Location = New System.Drawing.Point(11, 206)
        Me.rdoStructure.Name = "rdoStructure"
        Me.rdoStructure.Size = New System.Drawing.Size(104, 24)
        Me.rdoStructure.TabIndex = 3
        Me.rdoStructure.TabStop = True
        Me.rdoStructure.Tag = "Structure"
        Me.rdoStructure.Text = "Structure"
        Me.rdoStructure.UseVisualStyleBackColor = True
        '
        'rdoAllContents
        '
        Me.rdoAllContents.Location = New System.Drawing.Point(117, 206)
        Me.rdoAllContents.Name = "rdoAllContents"
        Me.rdoAllContents.Size = New System.Drawing.Size(104, 24)
        Me.rdoAllContents.TabIndex = 2
        Me.rdoAllContents.TabStop = True
        Me.rdoAllContents.Tag = "All_Contents"
        Me.rdoAllContents.Text = "All Contents"
        Me.rdoAllContents.UseVisualStyleBackColor = True
        '
        'rdoComponent
        '
        Me.rdoComponent.Location = New System.Drawing.Point(223, 206)
        Me.rdoComponent.Name = "rdoComponent"
        Me.rdoComponent.Size = New System.Drawing.Size(104, 24)
        Me.rdoComponent.TabIndex = 1
        Me.rdoComponent.TabStop = True
        Me.rdoComponent.Tag = "Component"
        Me.rdoComponent.Text = "Component"
        Me.rdoComponent.UseVisualStyleBackColor = True
        '
        'rdoViewGraph
        '
        Me.rdoViewGraph.Location = New System.Drawing.Point(329, 206)
        Me.rdoViewGraph.Name = "rdoViewGraph"
        Me.rdoViewGraph.Size = New System.Drawing.Size(104, 24)
        Me.rdoViewGraph.TabIndex = 0
        Me.rdoViewGraph.TabStop = True
        Me.rdoViewGraph.Text = "View Graph"
        Me.rdoViewGraph.UseVisualStyleBackColor = True
        '
        'dlgViewDescriptives
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 306)
        Me.Controls.Add(Me.rdoViewGraph)
        Me.Controls.Add(Me.rdoComponent)
        Me.Controls.Add(Me.rdoAllContents)
        Me.Controls.Add(Me.rdoStructure)
        Me.Controls.Add(Me.ucrReceiverSelectedObject)
        Me.Controls.Add(Me.lblSelectedObject)
        Me.Controls.Add(Me.ucrSelectorForViewObject)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgViewDescriptives"
        Me.Tag = "View"
        Me.Text = "View Objects"
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
End Class
