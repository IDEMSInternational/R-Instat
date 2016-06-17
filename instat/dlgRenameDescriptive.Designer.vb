<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgRenameDescriptive
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorForRenameObject = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverCurrentName = New instat.ucrReceiverSingle()
        Me.lblCurrentName = New System.Windows.Forms.Label()
        Me.lblNewName = New System.Windows.Forms.Label()
        Me.ucrInputNewName = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(13, 196)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorForRenameObject
        '
        Me.ucrSelectorForRenameObject.Location = New System.Drawing.Point(13, 13)
        Me.ucrSelectorForRenameObject.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForRenameObject.Name = "ucrSelectorForRenameObject"
        Me.ucrSelectorForRenameObject.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForRenameObject.TabIndex = 1
        '
        'ucrReceiverCurrentName
        '
        Me.ucrReceiverCurrentName.Location = New System.Drawing.Point(279, 39)
        Me.ucrReceiverCurrentName.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverCurrentName.Name = "ucrReceiverCurrentName"
        Me.ucrReceiverCurrentName.Selector = Nothing
        Me.ucrReceiverCurrentName.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverCurrentName.TabIndex = 2
        '
        'lblCurrentName
        '
        Me.lblCurrentName.AutoSize = True
        Me.lblCurrentName.Location = New System.Drawing.Point(276, 21)
        Me.lblCurrentName.Name = "lblCurrentName"
        Me.lblCurrentName.Size = New System.Drawing.Size(72, 13)
        Me.lblCurrentName.TabIndex = 3
        Me.lblCurrentName.Tag = "Current_Name"
        Me.lblCurrentName.Text = "Current Name"
        '
        'lblNewName
        '
        Me.lblNewName.AutoSize = True
        Me.lblNewName.Location = New System.Drawing.Point(276, 148)
        Me.lblNewName.Name = "lblNewName"
        Me.lblNewName.Size = New System.Drawing.Size(60, 13)
        Me.lblNewName.TabIndex = 4
        Me.lblNewName.Tag = "New_Name"
        Me.lblNewName.Text = "New Name"
        '
        'ucrInputNewName
        '
        Me.ucrInputNewName.IsReadOnly = False
        Me.ucrInputNewName.Location = New System.Drawing.Point(279, 164)
        Me.ucrInputNewName.Name = "ucrInputNewName"
        Me.ucrInputNewName.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputNewName.TabIndex = 5
        '
        'dlgRenameDescriptive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 259)
        Me.Controls.Add(Me.ucrInputNewName)
        Me.Controls.Add(Me.lblNewName)
        Me.Controls.Add(Me.lblCurrentName)
        Me.Controls.Add(Me.ucrReceiverCurrentName)
        Me.Controls.Add(Me.ucrSelectorForRenameObject)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgRenameDescriptive"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Rename_Object"
        Me.Text = "Rename Object"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForRenameObject As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverCurrentName As ucrReceiverSingle
    Friend WithEvents lblCurrentName As Label
    Friend WithEvents lblNewName As Label
    Friend WithEvents ucrInputNewName As ucrInputTextBox
End Class
