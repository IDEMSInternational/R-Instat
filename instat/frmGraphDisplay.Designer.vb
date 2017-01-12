<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGraphDisplay
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
        Me.pctGraph = New System.Windows.Forms.PictureBox()
        CType(Me.pctGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctGraph
        '
        Me.pctGraph.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pctGraph.Location = New System.Drawing.Point(0, 0)
        Me.pctGraph.Name = "pctGraph"
        Me.pctGraph.Size = New System.Drawing.Size(483, 412)
        Me.pctGraph.TabIndex = 0
        Me.pctGraph.TabStop = False
        '
        'frmGraphDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 412)
        Me.Controls.Add(Me.pctGraph)
        Me.Name = "frmGraphDisplay"
        Me.ShowIcon = False
        Me.Text = "Graph Display"
        CType(Me.pctGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pctGraph As PictureBox
End Class
