<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgEvapotranspiration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgEvapotranspiration))
        Me.tbpEvapotranspiration = New System.Windows.Forms.TabControl()
        Me.tbpPenmanMonteith = New System.Windows.Forms.TabPage()
        Me.tbpHargreaves = New System.Windows.Forms.TabPage()
        Me.ucrBase = New instat.ucrButtons()
        Me.tbpEvapotranspiration.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbpEvapotranspiration
        '
        Me.tbpEvapotranspiration.Controls.Add(Me.tbpPenmanMonteith)
        Me.tbpEvapotranspiration.Controls.Add(Me.tbpHargreaves)
        resources.ApplyResources(Me.tbpEvapotranspiration, "tbpEvapotranspiration")
        Me.tbpEvapotranspiration.Name = "tbpEvapotranspiration"
        Me.tbpEvapotranspiration.SelectedIndex = 0
        '
        'tbpPenmanMonteith
        '
        resources.ApplyResources(Me.tbpPenmanMonteith, "tbpPenmanMonteith")
        Me.tbpPenmanMonteith.Name = "tbpPenmanMonteith"
        Me.tbpPenmanMonteith.UseVisualStyleBackColor = True
        '
        'tbpHargreaves
        '
        resources.ApplyResources(Me.tbpHargreaves, "tbpHargreaves")
        Me.tbpHargreaves.Name = "tbpHargreaves"
        Me.tbpHargreaves.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgEvapotranspiration
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbpEvapotranspiration)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgEvapotranspiration"
        Me.tbpEvapotranspiration.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents tbpEvapotranspiration As TabControl
    Friend WithEvents tbpPenmanMonteith As TabPage
    Friend WithEvents tbpHargreaves As TabPage
End Class
