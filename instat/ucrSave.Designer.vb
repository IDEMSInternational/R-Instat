<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrSave
    Inherits instat.ucrCore

    'UserControl overrides dispose to clean up the component list.
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ucrChkSave = New instat.ucrCheck()
        Me.lblSaveText = New System.Windows.Forms.Label()
        Me.ucrInputComboSave = New instat.ucrInputComboBox()
        Me.SuspendLayout()
        '
        'ucrChkSave
        '
        Me.ucrChkSave.Checked = False
        Me.ucrChkSave.Location = New System.Drawing.Point(0, 0)
        Me.ucrChkSave.Name = "ucrChkSave"
        Me.ucrChkSave.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkSave.TabIndex = 0
        '
        'lblSaveText
        '
        Me.lblSaveText.AutoSize = True
        Me.lblSaveText.Location = New System.Drawing.Point(0, 3)
        Me.lblSaveText.Name = "lblSaveText"
        Me.lblSaveText.Size = New System.Drawing.Size(39, 13)
        Me.lblSaveText.TabIndex = 1
        Me.lblSaveText.Text = "Label1"
        '
        'ucrInputComboSave
        '
        Me.ucrInputComboSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.ucrInputComboSave.IsReadOnly = False
        Me.ucrInputComboSave.Location = New System.Drawing.Point(128, 0)
        Me.ucrInputComboSave.Name = "ucrInputComboSave"
        Me.ucrInputComboSave.Size = New System.Drawing.Size(173, 24)
        Me.ucrInputComboSave.TabIndex = 2
        '
        'ucrSave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputComboSave)
        Me.Controls.Add(Me.lblSaveText)
        Me.Controls.Add(Me.ucrChkSave)
        Me.Name = "ucrSave"
        Me.Size = New System.Drawing.Size(301, 24)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrChkSave As ucrCheck
    Friend WithEvents lblSaveText As Label
    Friend WithEvents ucrInputComboSave As ucrInputComboBox
End Class
