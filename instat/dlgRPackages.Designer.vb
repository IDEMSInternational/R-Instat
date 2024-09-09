<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgInstallRPackage
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
        Me.ucrInputPackage = New instat.ucrInputComboBox()
        Me.SuspendLayout()
        '
        'cmdCheck
        '
        Me.cmdCheck.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCheck.Location = New System.Drawing.Point(18, 150)
        Me.cmdCheck.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCheck.Name = "cmdCheck"
        Me.cmdCheck.Size = New System.Drawing.Size(112, 33)
        Me.cmdCheck.TabIndex = 7
        Me.cmdCheck.Text = "Check"
        Me.cmdCheck.UseVisualStyleBackColor = True
        '
        'lblRPackage
        '
        Me.lblRPackage.AutoSize = True
        Me.lblRPackage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRPackage.Location = New System.Drawing.Point(17, 68)
        Me.lblRPackage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRPackage.Name = "lblRPackage"
        Me.lblRPackage.Size = New System.Drawing.Size(91, 20)
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
        Me.rdoCRAN.Location = New System.Drawing.Point(206, 9)
        Me.rdoCRAN.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoCRAN.Name = "rdoCRAN"
        Me.rdoCRAN.Size = New System.Drawing.Size(136, 42)
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
        Me.rdoRPackage.Location = New System.Drawing.Point(338, 9)
        Me.rdoRPackage.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoRPackage.Name = "rdoRPackage"
        Me.rdoRPackage.Size = New System.Drawing.Size(136, 42)
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
        Me.lblRepository.Location = New System.Drawing.Point(15, 108)
        Me.lblRepository.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRepository.Name = "lblRepository"
        Me.lblRepository.Size = New System.Drawing.Size(135, 20)
        Me.lblRepository.TabIndex = 5
        Me.lblRepository.Text = "Repository Name:"
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(15, 199)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 9
        '
        'ucrInputTextBoxRPackage
        '
        Me.ucrInputTextBoxRPackage.AddQuotesIfUnrecognised = True
        Me.ucrInputTextBoxRPackage.AutoSize = True
        Me.ucrInputTextBoxRPackage.IsMultiline = False
        Me.ucrInputTextBoxRPackage.IsReadOnly = False
        Me.ucrInputTextBoxRPackage.Location = New System.Drawing.Point(151, 66)
        Me.ucrInputTextBoxRPackage.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputTextBoxRPackage.Name = "ucrInputTextBoxRPackage"
        Me.ucrInputTextBoxRPackage.Size = New System.Drawing.Size(296, 33)
        Me.ucrInputTextBoxRPackage.TabIndex = 4
        '
        'ucrPnlRPackages
        '
        Me.ucrPnlRPackages.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlRPackages.Location = New System.Drawing.Point(174, 8)
        Me.ucrPnlRPackages.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlRPackages.Name = "ucrPnlRPackages"
        Me.ucrPnlRPackages.Size = New System.Drawing.Size(339, 51)
        Me.ucrPnlRPackages.TabIndex = 0
        '
        'ucrInputMessage
        '
        Me.ucrInputMessage.AddQuotesIfUnrecognised = True
        Me.ucrInputMessage.AutoSize = True
        Me.ucrInputMessage.IsMultiline = False
        Me.ucrInputMessage.IsReadOnly = True
        Me.ucrInputMessage.Location = New System.Drawing.Point(151, 150)
        Me.ucrInputMessage.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputMessage.Name = "ucrInputMessage"
        Me.ucrInputMessage.Size = New System.Drawing.Size(475, 33)
        Me.ucrInputMessage.TabIndex = 8
        '
        'ucrInputRepositoryName
        '
        Me.ucrInputRepositoryName.AddQuotesIfUnrecognised = True
        Me.ucrInputRepositoryName.AutoSize = True
        Me.ucrInputRepositoryName.IsMultiline = False
        Me.ucrInputRepositoryName.IsReadOnly = False
        Me.ucrInputRepositoryName.Location = New System.Drawing.Point(151, 105)
        Me.ucrInputRepositoryName.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputRepositoryName.Name = "ucrInputRepositoryName"
        Me.ucrInputRepositoryName.Size = New System.Drawing.Size(471, 33)
        Me.ucrInputRepositoryName.TabIndex = 6
        '
        'ucrInputPackage
        '
        Me.ucrInputPackage.AddQuotesIfUnrecognised = True
        Me.ucrInputPackage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPackage.GetSetSelectedIndex = -1
        Me.ucrInputPackage.IsReadOnly = False
        Me.ucrInputPackage.Location = New System.Drawing.Point(151, 61)
        Me.ucrInputPackage.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrInputPackage.Name = "ucrInputPackage"
        Me.ucrInputPackage.Size = New System.Drawing.Size(323, 32)
        Me.ucrInputPackage.TabIndex = 10
        '
        'dlgInstallRPackage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(645, 291)
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
        Me.Controls.Add(Me.ucrInputPackage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents ucrInputPackage As ucrInputComboBox
End Class
