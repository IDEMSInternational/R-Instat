<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrVariablesAsFactor
    Inherits System.Windows.Forms.UserControl

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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ucrMultipleVariables = New instat.ucrReceiverMultiple()
        Me.ucrSingleVariable = New instat.ucrReceiverSingle()
        Me.cmdVariables = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrMultipleVariables
        '
        Me.ucrMultipleVariables.Location = New System.Drawing.Point(3, 31)
        Me.ucrMultipleVariables.Name = "ucrMultipleVariables"
        Me.ucrMultipleVariables.Selector = Nothing
        Me.ucrMultipleVariables.Size = New System.Drawing.Size(121, 104)
        Me.ucrMultipleVariables.TabIndex = 1
        '
        'ucrSingleVariable
        '
        Me.ucrSingleVariable.Location = New System.Drawing.Point(9, 35)
        Me.ucrSingleVariable.Name = "ucrSingleVariable"
        Me.ucrSingleVariable.Selector = Nothing
        Me.ucrSingleVariable.Size = New System.Drawing.Size(107, 26)
        Me.ucrSingleVariable.TabIndex = 2
        '
        'cmdVariables
        '
        Me.cmdVariables.Location = New System.Drawing.Point(9, 3)
        Me.cmdVariables.Name = "cmdVariables"
        Me.cmdVariables.Size = New System.Drawing.Size(107, 23)
        Me.cmdVariables.TabIndex = 3
        Me.cmdVariables.Tag = "Single_Variable"
        Me.cmdVariables.Text = "Single Variable"
        Me.cmdVariables.UseVisualStyleBackColor = True
        '
        'ucrVariablesAsFactor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdVariables)
        Me.Controls.Add(Me.ucrSingleVariable)
        Me.Controls.Add(Me.ucrMultipleVariables)
        Me.Name = "ucrVariablesAsFactor"
        Me.Size = New System.Drawing.Size(125, 136)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ucrMultipleVariables As ucrReceiverMultiple
    Friend WithEvents ucrSingleVariable As ucrReceiverSingle
    Friend WithEvents cmdVariables As Button
End Class
