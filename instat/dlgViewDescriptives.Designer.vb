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
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 261)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorForViewObject
        '
        Me.ucrSelectorForViewObject.Location = New System.Drawing.Point(9, 9)
        Me.ucrSelectorForViewObject.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForViewObject.Name = "ucrSelectorForViewObject"
        Me.ucrSelectorForViewObject.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForViewObject.TabIndex = 1
        '
        'lblSelectedObject
        '
        Me.lblSelectedObject.AutoSize = True
        Me.lblSelectedObject.Location = New System.Drawing.Point(222, 19)
        Me.lblSelectedObject.Name = "lblSelectedObject"
        Me.lblSelectedObject.Size = New System.Drawing.Size(83, 13)
        Me.lblSelectedObject.TabIndex = 2
        Me.lblSelectedObject.Text = "Selected Object"
        '
        'ucrReceiverSelectedObject
        '
        Me.ucrReceiverSelectedObject.Location = New System.Drawing.Point(225, 40)
        Me.ucrReceiverSelectedObject.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSelectedObject.Name = "ucrReceiverSelectedObject"
        Me.ucrReceiverSelectedObject.Selector = Nothing
        Me.ucrReceiverSelectedObject.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSelectedObject.TabIndex = 3
        '
        'rdoStructure
        '
        Me.rdoStructure.AutoSize = True
        Me.rdoStructure.Enabled = False
        Me.rdoStructure.Location = New System.Drawing.Point(12, 228)
        Me.rdoStructure.Name = "rdoStructure"
        Me.rdoStructure.Size = New System.Drawing.Size(68, 17)
        Me.rdoStructure.TabIndex = 4
        Me.rdoStructure.TabStop = True
        Me.rdoStructure.Tag = "Structure"
        Me.rdoStructure.Text = "Structure"
        Me.rdoStructure.UseVisualStyleBackColor = True
        '
        'rdoAllContents
        '
        Me.rdoAllContents.AutoSize = True
        Me.rdoAllContents.Enabled = False
        Me.rdoAllContents.Location = New System.Drawing.Point(86, 228)
        Me.rdoAllContents.Name = "rdoAllContents"
        Me.rdoAllContents.Size = New System.Drawing.Size(81, 17)
        Me.rdoAllContents.TabIndex = 5
        Me.rdoAllContents.TabStop = True
        Me.rdoAllContents.Tag = "All_Contents"
        Me.rdoAllContents.Text = "All Contents"
        Me.rdoAllContents.UseVisualStyleBackColor = True
        '
        'rdoComponent
        '
        Me.rdoComponent.AutoSize = True
        Me.rdoComponent.Enabled = False
        Me.rdoComponent.Location = New System.Drawing.Point(173, 228)
        Me.rdoComponent.Name = "rdoComponent"
        Me.rdoComponent.Size = New System.Drawing.Size(79, 17)
        Me.rdoComponent.TabIndex = 6
        Me.rdoComponent.TabStop = True
        Me.rdoComponent.Tag = "Component"
        Me.rdoComponent.Text = "Component"
        Me.rdoComponent.UseVisualStyleBackColor = True
        '
        'dlgViewDescriptives
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 326)
        Me.Controls.Add(Me.rdoComponent)
        Me.Controls.Add(Me.rdoAllContents)
        Me.Controls.Add(Me.rdoStructure)
        Me.Controls.Add(Me.ucrReceiverSelectedObject)
        Me.Controls.Add(Me.lblSelectedObject)
        Me.Controls.Add(Me.ucrSelectorForViewObject)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgViewDescriptives"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "View"
        Me.Text = "View Object"
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
End Class
