<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgExtremesMethod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgExtremesMethod))
        Me.UcrPanel1 = New instat.UcrPanel()
        Me.rdoMLE = New System.Windows.Forms.RadioButton()
        Me.rdoGMLE = New System.Windows.Forms.RadioButton()
        Me.rdoBayesian = New System.Windows.Forms.RadioButton()
        Me.rdoLmoments = New System.Windows.Forms.RadioButton()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'UcrPanel1
        '
        resources.ApplyResources(Me.UcrPanel1, "UcrPanel1")
        Me.UcrPanel1.Name = "UcrPanel1"
        '
        'rdoMLE
        '
        resources.ApplyResources(Me.rdoMLE, "rdoMLE")
        Me.rdoMLE.Name = "rdoMLE"
        Me.rdoMLE.TabStop = True
        Me.rdoMLE.UseVisualStyleBackColor = True
        '
        'rdoGMLE
        '
        resources.ApplyResources(Me.rdoGMLE, "rdoGMLE")
        Me.rdoGMLE.Name = "rdoGMLE"
        Me.rdoGMLE.TabStop = True
        Me.rdoGMLE.UseVisualStyleBackColor = True
        '
        'rdoBayesian
        '
        resources.ApplyResources(Me.rdoBayesian, "rdoBayesian")
        Me.rdoBayesian.Name = "rdoBayesian"
        Me.rdoBayesian.TabStop = True
        Me.rdoBayesian.UseVisualStyleBackColor = True
        '
        'rdoLmoments
        '
        resources.ApplyResources(Me.rdoLmoments, "rdoLmoments")
        Me.rdoLmoments.Name = "rdoLmoments"
        Me.rdoLmoments.TabStop = True
        Me.rdoLmoments.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'sdgExtremesMethod
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.rdoLmoments)
        Me.Controls.Add(Me.rdoBayesian)
        Me.Controls.Add(Me.rdoGMLE)
        Me.Controls.Add(Me.rdoMLE)
        Me.Controls.Add(Me.UcrPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgExtremesMethod"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcrPanel1 As UcrPanel
    Friend WithEvents rdoMLE As RadioButton
    Friend WithEvents rdoGMLE As RadioButton
    Friend WithEvents rdoBayesian As RadioButton
    Friend WithEvents rdoLmoments As RadioButton
    Friend WithEvents ucrBase As ucrButtonsSubdialogue
End Class
