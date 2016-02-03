<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgCreateClimateObject
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
        Me.ucrBase = New instat.ucrButtons()
        Me.UcrDataFrame = New instat.ucrDataFrame()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 291)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 56)
        Me.ucrBase.TabIndex = 0
        '
        'UcrDataFrame
        '
        Me.UcrDataFrame.Location = New System.Drawing.Point(12, 23)
        Me.UcrDataFrame.Name = "UcrDataFrame"
        Me.UcrDataFrame.Size = New System.Drawing.Size(127, 41)
        Me.UcrDataFrame.TabIndex = 1
        '
        'dlgCreateClimateObject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 359)
        Me.Controls.Add(Me.UcrDataFrame)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCreateClimateObject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Import_into_climate_object"
        Me.Text = "Import into climate object"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents UcrDataFrame As ucrDataFrame
End Class
