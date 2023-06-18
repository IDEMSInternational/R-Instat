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
        Me.cmdCheck = New System.Windows.Forms.Button()
        Me.lblRPackage = New System.Windows.Forms.Label()
        Me.ucrInputMessage = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputTextBoxRPackage = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'cmdCheck
        '
        Me.cmdCheck.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCheck.Location = New System.Drawing.Point(14, 81)
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.Size = New System.Drawing.Size(75, 22)
        Me.cmdCheck.TabIndex = 16
        Me.cmdCheck.Text = "Check"
        Me.cmdCheck.UseVisualStyleBackColor = True
        '
        'lblRPackage
        '
        Me.lblRPackage.AutoSize = True
        Me.lblRPackage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRPackage.Location = New System.Drawing.Point(11, 33)
        Me.lblRPackage.Name = "lblRPackage"
        Me.lblRPackage.Size = New System.Drawing.Size(64, 13)
        Me.lblRPackage.TabIndex = 1
        Me.lblRPackage.Text = "R Package:"
        '
        'ucrInputMessage
        '
        Me.ucrInputMessage.AddQuotesIfUnrecognised = True
        Me.ucrInputMessage.AutoSize = True
        Me.ucrInputMessage.IsMultiline = False
        Me.ucrInputMessage.IsReadOnly = True
        Me.ucrInputMessage.Location = New System.Drawing.Point(105, 81)
        Me.ucrInputMessage.Name = "ucrInputMessage"
        Me.ucrInputMessage.Size = New System.Drawing.Size(319, 22)
        Me.ucrInputMessage.TabIndex = 17
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(14, 130)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 15
        '
        'ucrInputTextBoxRPackage
        '
        Me.ucrInputTextBoxRPackage.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBoxRPackage.AutoSize = True
        Me.ucrInputTextBoxRPackage.IsMultiline = False
        Me.ucrInputTextBoxRPackage.IsReadOnly = False
        Me.ucrInputTextBoxRPackage.Location = New System.Drawing.Point(75, 31)
        Me.ucrInputTextBoxRPackage.Name = "ucrInputTextBoxRPackage"
        Me.ucrInputTextBoxRPackage.Size = New System.Drawing.Size(197, 22)
        Me.ucrInputTextBoxRPackage.TabIndex = 0
        '
        'dlgInstallRPackage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(448, 194)
        Me.Controls.Add(Me.ucrInputMessage)
        Me.Controls.Add(Me.cmdCheck)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblRPackage)
        Me.Controls.Add(Me.ucrInputTextBoxRPackage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgInstallRPackage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "R Packages"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInputTextBoxRPackage As ucrInputTextBox
    Friend WithEvents ucrInputMessage As ucrInputTextBox
    Friend WithEvents cmdCheck As Button
    Friend WithEvents lblRPackage As Label
End Class
