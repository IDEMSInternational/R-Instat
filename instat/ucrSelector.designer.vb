<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrSelector
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblVariables = New System.Windows.Forms.Label()
        Me.lstAvailableVariable = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'lblVariables
        '
        Me.lblVariables.AutoSize = True
        Me.lblVariables.Location = New System.Drawing.Point(5, 2)
        Me.lblVariables.Name = "lblVariables"
        Me.lblVariables.Size = New System.Drawing.Size(53, 13)
        Me.lblVariables.TabIndex = 82
        Me.lblVariables.Tag = "Variables:"
        Me.lblVariables.Text = "Variables:"
        '
        'lstAvailableVariable
        '
        Me.lstAvailableVariable.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.lstAvailableVariable.GridLines = True
        Me.lstAvailableVariable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstAvailableVariable.HideSelection = False
        Me.lstAvailableVariable.Location = New System.Drawing.Point(8, 18)
        Me.lstAvailableVariable.Name = "lstAvailableVariable"
        Me.lstAvailableVariable.Size = New System.Drawing.Size(113, 104)
        Me.lstAvailableVariable.TabIndex = 83
        Me.lstAvailableVariable.UseCompatibleStateImageBehavior = False
        Me.lstAvailableVariable.View = System.Windows.Forms.View.Details
        '
        'ucrSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lstAvailableVariable)
        Me.Controls.Add(Me.lblVariables)
        Me.Name = "ucrSelector"
        Me.Size = New System.Drawing.Size(124, 127)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Protected Friend WithEvents lblVariables As Label
    Protected Friend WithEvents lstAvailableVariable As ListView
End Class
