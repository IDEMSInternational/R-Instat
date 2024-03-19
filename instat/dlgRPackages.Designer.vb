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
        Me.rdoCRAN = New System.Windows.Forms.RadioButton()
        Me.rdoRPackage = New System.Windows.Forms.RadioButton()
        Me.lblRepository = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputTextBoxRPackage = New instat.ucrInputTextBox()
        Me.ucrPnlRPackages = New instat.UcrPanel()
        Me.ucrInputMessage = New instat.ucrInputTextBox()
        Me.ucrInputRepositoryName = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'cmdCheck
        '
        Me.cmdCheck.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCheck.Location = New System.Drawing.Point(14, 94)
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.Size = New System.Drawing.Size(75, 22)
        Me.cmdCheck.TabIndex = 7
        Me.cmdCheck.Text = "Check"
        Me.cmdCheck.UseVisualStyleBackColor = True
        '
        'lblRPackage
        '
        Me.lblRPackage.AutoSize = True
        Me.lblRPackage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRPackage.Location = New System.Drawing.Point(21, 44)
        Me.lblRPackage.Name = "lblRPackage"
        Me.lblRPackage.Size = New System.Drawing.Size(64, 13)
        Me.lblRPackage.TabIndex = 3
        Me.lblRPackage.Text = "R Package:"
        '
        'rdoCRAN
        '
        Me.rdoCRAN.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoCRAN.BackColor = System.Drawing.SystemColors.Control
        Me.rdoCRAN.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCRAN.FlatAppearance.BorderSize = 2
        Me.rdoCRAN.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCRAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoCRAN.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCRAN.Location = New System.Drawing.Point(104, 3)
        Me.rdoCRAN.Name = "rdoCRAN"
        Me.rdoCRAN.Size = New System.Drawing.Size(91, 28)
        Me.rdoCRAN.TabIndex = 1
        Me.rdoCRAN.TabStop = True
        Me.rdoCRAN.Tag = "Frequency"
        Me.rdoCRAN.Text = "CRAN"
        Me.rdoCRAN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoCRAN.UseVisualStyleBackColor = False
        '
        'rdoRPackage
        '
        Me.rdoRPackage.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoRPackage.BackColor = System.Drawing.SystemColors.Control
        Me.rdoRPackage.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRPackage.FlatAppearance.BorderSize = 2
        Me.rdoRPackage.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoRPackage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRPackage.Location = New System.Drawing.Point(192, 3)
        Me.rdoRPackage.Name = "rdoRPackage"
        Me.rdoRPackage.Size = New System.Drawing.Size(91, 28)
        Me.rdoRPackage.TabIndex = 2
        Me.rdoRPackage.TabStop = True
        Me.rdoRPackage.Tag = "Frequency"
        Me.rdoRPackage.Text = "R Package "
        Me.rdoRPackage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRPackage.UseVisualStyleBackColor = False
        '
        'lblRepository
        '
        Me.lblRepository.AutoSize = True
        Me.lblRepository.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRepository.Location = New System.Drawing.Point(3, 72)
        Me.lblRepository.Name = "lblRepository"
        Me.lblRepository.Size = New System.Drawing.Size(91, 13)
        Me.lblRepository.TabIndex = 5
        Me.lblRepository.Text = "Repository Name:"
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(24, 130)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 9
        '
        'ucrInputTextBoxRPackage
        '
        Me.ucrInputTextBoxRPackage.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBoxRPackage.AutoSize = True
        Me.ucrInputTextBoxRPackage.IsMultiline = False
        Me.ucrInputTextBoxRPackage.IsReadOnly = False
        Me.ucrInputTextBoxRPackage.Location = New System.Drawing.Point(95, 42)
        Me.ucrInputTextBoxRPackage.Name = "ucrInputTextBoxRPackage"
        Me.ucrInputTextBoxRPackage.Size = New System.Drawing.Size(197, 22)
        Me.ucrInputTextBoxRPackage.TabIndex = 4
        '
        'ucrPnlRPackages
        '
        Me.ucrPnlRPackages.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlRPackages.Location = New System.Drawing.Point(83, 2)
        Me.ucrPnlRPackages.Name = "ucrPnlRPackages"
        Me.ucrPnlRPackages.Size = New System.Drawing.Size(226, 34)
        Me.ucrPnlRPackages.TabIndex = 0
        '
        'ucrInputMessage
        '
        Me.ucrInputMessage.AddQuotesIfUnrecognised = True
        Me.ucrInputMessage.AutoSize = True
        Me.ucrInputMessage.IsMultiline = False
        Me.ucrInputMessage.IsReadOnly = True
        Me.ucrInputMessage.Location = New System.Drawing.Point(95, 94)
        Me.ucrInputMessage.Name = "ucrInputMessage"
        Me.ucrInputMessage.Size = New System.Drawing.Size(337, 22)
        Me.ucrInputMessage.TabIndex = 8
        '
        'ucrInputRepositoryName
        '
        Me.ucrInputRepositoryName.AddQuotesIfUnrecognised = True
        Me.ucrInputRepositoryName.AutoSize = True
        Me.ucrInputRepositoryName.IsMultiline = False
        Me.ucrInputRepositoryName.IsReadOnly = False
        Me.ucrInputRepositoryName.Location = New System.Drawing.Point(93, 69)
        Me.ucrInputRepositoryName.Name = "ucrInputRepositoryName"
        Me.ucrInputRepositoryName.Size = New System.Drawing.Size(197, 22)
        Me.ucrInputRepositoryName.TabIndex = 6
        '
        'dlgInstallRPackage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(448, 194)
        Me.Controls.Add(Me.rdoRPackage)
        Me.Controls.Add(Me.rdoCRAN)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblRPackage)
        Me.Controls.Add(Me.ucrInputTextBoxRPackage)
        Me.Controls.Add(Me.ucrPnlRPackages)
        Me.Controls.Add(Me.ucrInputRepositoryName)
        Me.Controls.Add(Me.lblRepository)
        Me.Controls.Add(Me.cmdCheck)
        Me.Controls.Add(Me.ucrInputMessage)
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
    Friend WithEvents ucrPnlRPackages As UcrPanel
    Friend WithEvents rdoCRAN As RadioButton
    Friend WithEvents rdoRPackage As RadioButton
    Friend WithEvents lblRepository As Label
    Friend WithEvents ucrInputRepositoryName As ucrInputTextBox
End Class
