<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrSaveGraph
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
        Me.ucrInputGraphName = New instat.ucrInputComboBox()
        Me.chkSaveGraph = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ucrInputGraphName
        '
        Me.ucrInputGraphName.Location = New System.Drawing.Point(86, 0)
        Me.ucrInputGraphName.Name = "ucrInputGraphName"
        Me.ucrInputGraphName.Size = New System.Drawing.Size(180, 20)
        Me.ucrInputGraphName.TabIndex = 0
        '
        'chkSaveGraph
        '
        Me.chkSaveGraph.AutoSize = True
        Me.chkSaveGraph.Location = New System.Drawing.Point(0, 3)
        Me.chkSaveGraph.Name = "chkSaveGraph"
        Me.chkSaveGraph.Size = New System.Drawing.Size(83, 17)
        Me.chkSaveGraph.TabIndex = 1
        Me.chkSaveGraph.Tag = "Save_Graph"
        Me.chkSaveGraph.Text = "Save Graph"
        Me.chkSaveGraph.UseVisualStyleBackColor = True
        '
        'ucrSaveGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chkSaveGraph)
        Me.Controls.Add(Me.ucrInputGraphName)
        Me.Name = "ucrSaveGraph"
        Me.Size = New System.Drawing.Size(265, 20)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrInputGraphName As ucrInputComboBox
    Friend WithEvents chkSaveGraph As CheckBox
End Class
