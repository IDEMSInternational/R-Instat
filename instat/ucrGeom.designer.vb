<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrGeom
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTypeofLayer = New System.Windows.Forms.Label()
        Me.ucrInputGeoms = New instat.ucrInputComboBox()
        Me.SuspendLayout()
        '
        'lblTypeofLayer
        '
        Me.lblTypeofLayer.AutoSize = True
        Me.lblTypeofLayer.Location = New System.Drawing.Point(4, 4)
        Me.lblTypeofLayer.Name = "lblTypeofLayer"
        Me.lblTypeofLayer.Size = New System.Drawing.Size(112, 13)
        Me.lblTypeofLayer.TabIndex = 1
        Me.lblTypeofLayer.Text = "Type of Layer (Geom):"
        Me.lblTypeofLayer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ucrInputGeoms
        '
        Me.ucrInputGeoms.AddQuotesIfUnrecognised = True
        Me.ucrInputGeoms.IsReadOnly = False
        Me.ucrInputGeoms.Location = New System.Drawing.Point(7, 22)
        Me.ucrInputGeoms.Name = "ucrInputGeoms"
        Me.ucrInputGeoms.Size = New System.Drawing.Size(151, 21)
        Me.ucrInputGeoms.TabIndex = 2
        '
        'ucrGeom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputGeoms)
        Me.Controls.Add(Me.lblTypeofLayer)
        Me.Name = "ucrGeom"
        Me.Size = New System.Drawing.Size(168, 50)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTypeofLayer As Label
    Friend WithEvents ucrInputGeoms As ucrInputComboBox
End Class
