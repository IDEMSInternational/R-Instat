<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrGeom
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
        Me.cboGeomList = New System.Windows.Forms.ComboBox()
        Me.lblTypeofLayer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboGeomList
        '
        Me.cboGeomList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboGeomList.FormattingEnabled = True
        Me.cboGeomList.Location = New System.Drawing.Point(3, 24)
        Me.cboGeomList.Name = "cboGeomList"
        Me.cboGeomList.Size = New System.Drawing.Size(164, 21)
        Me.cboGeomList.TabIndex = 0
        '
        'lblTypeofLayer
        '
        Me.lblTypeofLayer.AutoSize = True
        Me.lblTypeofLayer.Location = New System.Drawing.Point(4, 4)
        Me.lblTypeofLayer.Name = "lblTypeofLayer"
        Me.lblTypeofLayer.Size = New System.Drawing.Size(109, 13)
        Me.lblTypeofLayer.TabIndex = 1
        Me.lblTypeofLayer.Text = "Type of Layer(Geom):"
        Me.lblTypeofLayer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ucrGeom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblTypeofLayer)
        Me.Controls.Add(Me.cboGeomList)
        Me.Name = "ucrGeom"
        Me.Size = New System.Drawing.Size(182, 50)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboGeomList As ComboBox
    Friend WithEvents lblTypeofLayer As Label
End Class
