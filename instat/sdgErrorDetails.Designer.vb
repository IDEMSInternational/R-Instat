<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgErrorDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgErrorDetails))
        Me.ucrInputErrorMessage = New instat.ucrInputTextBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ucrInputErrorMessage
        '
        Me.ucrInputErrorMessage.AddQuotesIfUnrecognised = True
        Me.ucrInputErrorMessage.IsMultiline = False
        Me.ucrInputErrorMessage.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputErrorMessage, "ucrInputErrorMessage")
        Me.ucrInputErrorMessage.Name = "ucrInputErrorMessage"
        '
        'cmdClose
        '
        resources.ApplyResources(Me.cmdClose, "cmdClose")
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'sdgErrorDetails
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.ucrInputErrorMessage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgErrorDetails"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrInputErrorMessage As ucrInputTextBox
    Friend WithEvents cmdClose As Button
End Class
