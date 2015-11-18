<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDeleteColumns
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
        Me.lblVariables = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverMultiple = New instat.ucrReceiverMultiple()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.lstDeleteVariables = New System.Windows.Forms.ListBox()
        Me.lblDeleteVariables = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblVariables
        '
        Me.lblVariables.AutoSize = True
        Me.lblVariables.Location = New System.Drawing.Point(251, 10)
        Me.lblVariables.Name = "lblVariables"
        Me.lblVariables.Size = New System.Drawing.Size(50, 13)
        Me.lblVariables.TabIndex = 3
        Me.lblVariables.Tag = "Variables"
        Me.lblVariables.Text = "Variables"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 290)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 4
        '
        'ucrReceiverMultiple
        '
        Me.ucrReceiverMultiple.Location = New System.Drawing.Point(232, 29)
        Me.ucrReceiverMultiple.Name = "ucrReceiverMultiple"
        Me.ucrReceiverMultiple.Size = New System.Drawing.Size(91, 101)
        Me.ucrReceiverMultiple.TabIndex = 1
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(12, 12)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(182, 118)
        Me.ucrAddRemove.TabIndex = 0
        '
        'lstDeleteVariables
        '
        Me.lstDeleteVariables.FormattingEnabled = True
        Me.lstDeleteVariables.Location = New System.Drawing.Point(232, 176)
        Me.lstDeleteVariables.Name = "lstDeleteVariables"
        Me.lstDeleteVariables.Size = New System.Drawing.Size(120, 95)
        Me.lstDeleteVariables.TabIndex = 5
        '
        'lblDeleteVariables
        '
        Me.lblDeleteVariables.AutoSize = True
        Me.lblDeleteVariables.Location = New System.Drawing.Point(229, 150)
        Me.lblDeleteVariables.Name = "lblDeleteVariables"
        Me.lblDeleteVariables.Size = New System.Drawing.Size(115, 13)
        Me.lblDeleteVariables.TabIndex = 6
        Me.lblDeleteVariables.Tag = "Variables_to_be_delete"
        Me.lblDeleteVariables.Text = "Variables to be deleted"
        '
        'dlgDeleteColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 334)
        Me.Controls.Add(Me.lblDeleteVariables)
        Me.Controls.Add(Me.lstDeleteVariables)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblVariables)
        Me.Controls.Add(Me.ucrReceiverMultiple)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgDeleteColumns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Delete_columns"
        Me.Text = "Delete columns"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverMultiple As ucrReceiverMultiple
    Friend WithEvents lblVariables As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lstDeleteVariables As ListBox
    Friend WithEvents lblDeleteVariables As Label
End Class
