<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgName
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCurrentName = New System.Windows.Forms.Label()
        Me.ucrInputNewName = New instat.ucrInputTextBox()
        Me.ucrSelectVariables = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverName = New instat.ucrReceiverSingle()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(284, 75)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(60, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Tag = "New_Name"
        Me.lblName.Text = "New Name"
        '
        'lblCurrentName
        '
        Me.lblCurrentName.AutoSize = True
        Me.lblCurrentName.Location = New System.Drawing.Point(284, 15)
        Me.lblCurrentName.Name = "lblCurrentName"
        Me.lblCurrentName.Size = New System.Drawing.Size(72, 13)
        Me.lblCurrentName.TabIndex = 3
        Me.lblCurrentName.Text = "Current Name"
        '
        'ucrInputNewName
        '
        Me.ucrInputNewName.Location = New System.Drawing.Point(287, 91)
        Me.ucrInputNewName.Name = "ucrInputNewName"
        Me.ucrInputNewName.Size = New System.Drawing.Size(106, 21)
        Me.ucrInputNewName.TabIndex = 0
        '
        'ucrSelectVariables
        '
        Me.ucrSelectVariables.Location = New System.Drawing.Point(12, 12)
        Me.ucrSelectVariables.Name = "ucrSelectVariables"
        Me.ucrSelectVariables.Size = New System.Drawing.Size(226, 179)
        Me.ucrSelectVariables.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ucrBase.Location = New System.Drawing.Point(0, 194)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(416, 59)
        Me.ucrBase.TabIndex = 5
        '
        'ucrReceiverName
        '
        Me.ucrReceiverName.Location = New System.Drawing.Point(287, 31)
        Me.ucrReceiverName.Name = "ucrReceiverName"
        Me.ucrReceiverName.Selector = Nothing
        Me.ucrReceiverName.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverName.TabIndex = 2
        '
        'dlgName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 253)
        Me.Controls.Add(Me.ucrInputNewName)
        Me.Controls.Add(Me.lblCurrentName)
        Me.Controls.Add(Me.ucrSelectVariables)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.ucrReceiverName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgName"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Rename_Data_Column"
        Me.Text = "Rename Data Column"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrReceiverName As ucrReceiverSingle
    Friend WithEvents lblName As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectVariables As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblCurrentName As Label
    Friend WithEvents ucrInputNewName As ucrInputTextBox
End Class
