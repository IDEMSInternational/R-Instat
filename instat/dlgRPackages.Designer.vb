<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgInstallRPackage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgInstallRPackage))
        Me.cmdCheck = New System.Windows.Forms.Button()
        Me.lblRPackage = New System.Windows.Forms.Label()
        Me.ucrInputMessage = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputTextBoxRPackage = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'cmdCheck
        '
        resources.ApplyResources(Me.cmdCheck, "cmdCheck")
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.UseVisualStyleBackColor = True
        '
        'lblRPackage
        '
        resources.ApplyResources(Me.lblRPackage, "lblRPackage")
        Me.lblRPackage.Name = "lblRPackage"
        '
        'ucrInputMessage
        '
        Me.ucrInputMessage.AddQuotesIfUnrecognised = True
        Me.ucrInputMessage.IsMultiline = False
        Me.ucrInputMessage.IsReadOnly = True
        resources.ApplyResources(Me.ucrInputMessage, "ucrInputMessage")
        Me.ucrInputMessage.Name = "ucrInputMessage"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrInputTextBoxRPackage
        '
        Me.ucrInputTextBoxRPackage.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBoxRPackage.IsMultiline = False
        Me.ucrInputTextBoxRPackage.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTextBoxRPackage, "ucrInputTextBoxRPackage")
        Me.ucrInputTextBoxRPackage.Name = "ucrInputTextBoxRPackage"
        '
        'dlgInstallRPackage
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputMessage)
        Me.Controls.Add(Me.cmdCheck)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblRPackage)
        Me.Controls.Add(Me.ucrInputTextBoxRPackage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgInstallRPackage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInputTextBoxRPackage As ucrInputTextBox
    Friend WithEvents ucrInputMessage As ucrInputTextBox
    Friend WithEvents cmdCheck As Button
    Friend WithEvents lblRPackage As Label
End Class
